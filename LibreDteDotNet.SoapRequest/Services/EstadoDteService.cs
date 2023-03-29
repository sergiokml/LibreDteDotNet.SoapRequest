using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

using LibreDteDotNet.SoapRequest.Interfaces;

using Microsoft.Extensions.Configuration;

using ServiceEstadoDte;

using static LibreDteDotNet.SoapRequest.Interfaces.IEstadoDteService;

namespace LibreDteDotNet.SoapRequest.Services
{
    public class EstadoDteService : IEstadoDteService
    {
        private readonly IConfiguration configuration;

        public EstadoDteService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<XDocument> GetEstado(
            string RutCompania,
            string DvCompania,
            string RutReceptor,
            string DvReceptor,
            TipoDoc TipoDte,
            string FolioDte,
            string FechaEmisionDte,
            string MontoDte,
            string Token
        )
        {
            string rut = configuration.GetSection("Rut").Value!;
            QueryEstDteClient client = new();
            try
            {
                using OperationContextScope ocs = new(client.InnerChannel);
                HttpRequestMessageProperty prop = new();
                prop.Headers.Add(HttpRequestHeader.Cookie, $"TOKEN={Token}");
                OperationContext.Current.OutgoingMessageProperties.Add(
                    HttpRequestMessageProperty.Name,
                    prop
                );
                string response = await client.getEstDteAsync(
                    rut.Split('-').GetValue(0)!.ToString()!,
                    rut.Split('-').GetValue(1)!.ToString()!,
                    RutReceptor,
                    DvReceptor,
                    ((int)TipoDte).ToString(),
                    MontoDte,
                    FechaEmisionDte,
                    DvCompania,
                    FolioDte,
                    RutCompania,
                    Token
                );
                client.Close();
                if (response != null)
                {
                    return XDocument.Parse(response);
                }
            }
            catch (CommunicationException)
            {
                client.Abort();
            }
            catch (TimeoutException)
            {
                client.Abort();
            }
            catch (Exception)
            {
                client.Abort();
                throw;
            }
            return null!;
        }
    }
}
