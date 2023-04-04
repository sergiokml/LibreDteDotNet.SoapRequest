using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;

using Microsoft.Extensions.Configuration;

using ServiceEstadoDte;

namespace LibreDteDotNet.SoapRequest.Services
{
    internal class EstadoDteService : IEstadoDte
    {
        private readonly IConfiguration configuration;
        private getEstDteResponse? GetEstDteResponse { get; set; }

        public EstadoDteService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<IEstadoDte> GetEstado(
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
                getEstDteResponse response = await client.getEstDteAsync(
                    new getEstDteRequest()
                    {
                        RutConsultante = rut.Split('-').GetValue(0)!.ToString()!,
                        DvConsultante = rut.Split('-').GetValue(1)!.ToString()!,
                        RutCompania = RutReceptor,
                        DvCompania = DvReceptor,
                        TipoDte = ((int)TipoDte).ToString(),
                        MontoDte = MontoDte,
                        FechaEmisionDte = FechaEmisionDte,
                        DvReceptor = DvCompania,
                        FolioDte = FolioDte,
                        RutReceptor = RutCompania,
                        Token = Token
                    }
                );
                client.Close();
                if (response != null)
                {
                    GetEstDteResponse = response;
                    return this;
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

        public async Task<RESPUESTA> AsObject()
        {
            return await Deserializa<RESPUESTA>(GetEstDteResponse!.getEstDteReturn);
        }

        public async Task<XDocument> AsXDocument()
        {
            try
            {
                return await Task.Run(() =>
                {
                    return XDocument.Parse(GetEstDteResponse!.getEstDteReturn);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
