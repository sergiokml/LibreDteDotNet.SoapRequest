using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibreDteDotNet.SoapRequest.Static
{
    internal class Extension
    {
        internal static X509Certificate2 GetCertFromPc(string rut)
        {
            X509Store store = new(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
            var cert = store.Certificates
                .Where(c => c.Subject.Contains(rut) && c.NotAfter > DateTime.Now)
                .FirstOrDefault();
            store.Close();
            if (cert == null)
            {
                throw new Exception($"No existe certificado válido para este rut: {rut}.");
            }
            return cert!;
        }
    }
}
