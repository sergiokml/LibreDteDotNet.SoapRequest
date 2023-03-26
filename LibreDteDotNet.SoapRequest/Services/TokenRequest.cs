using ServiceSemilla;

using ServiceToken;

using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography.Xml;
using LibreDteDotNet.SoapRequest.Static;

namespace LibreDteDotNet.SoapRequest.Services
{
    public class TokenRequest
    {
        private const string DOCUMENTO = "<getToken><item><Semilla>{0}</Semilla></item></getToken>";
        private string? Rut { get; set; }

        public TokenRequest(string rut)
        {
            Rut = rut;
        }

        public async Task<string> GetToken()
        {
            CrSeedClient semilla = new();
            GetTokenFromSeedClient token = new();
            try
            {
                string seed = await semilla.getSeedAsync();
                if (seed != null)
                {
                    string xml = GetElement(seed, "SEMILLA");
                    string xmlNofirmado = string.Format(DOCUMENTO, xml);
                    string xmlfirmado = FirmarXml(xmlNofirmado);
                    string tkn = await token.getTokenAsync(xmlfirmado);
                    return GetElement(tkn, "TOKEN");
                }
                semilla.Close();
            }
            catch (CommunicationException)
            {
                semilla.Abort();
            }
            catch (TimeoutException)
            {
                semilla.Abort();
            }
            catch (Exception)
            {
                semilla.Abort();
                throw;
            }
            return null!;
        }

        private string FirmarXml(string documento)
        {
            // https://www.sii.cl/factura_electronica/factura_mercado/autenticacion.pdf
            X509Certificate2 x509 = Extension.GetCertFromPc(Rut!);
            RSA? privateKey = x509.GetRSAPrivateKey();
            try
            {
                XmlDocument doc = new() { PreserveWhitespace = true };
                doc.LoadXml(documento);
                SignedXml signedXml = new(doc) { SigningKey = privateKey };
                Signature XMLSignature = signedXml.Signature;
                Reference reference = new("");
                reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                XMLSignature.SignedInfo.AddReference(reference);
                KeyInfo keyInfo = new();
                keyInfo.AddClause(new RSAKeyValue(privateKey));
                keyInfo.AddClause(new KeyInfoX509Data(x509));
                XMLSignature.KeyInfo = keyInfo;
                signedXml.ComputeSignature();
                XmlElement xmlDigitalSignature = signedXml.GetXml();
                _ = doc.DocumentElement!.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                if (doc.FirstChild is XmlDeclaration)
                {
                    _ = doc.RemoveChild(doc.FirstChild);
                }
                return doc.InnerXml;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static string GetElement(string xml, string node)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return (string)doc.Descendants(node).Single();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
