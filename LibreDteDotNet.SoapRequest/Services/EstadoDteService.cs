using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

using LibreDteDotNet.Common;
using LibreDteDotNet.Common.Models;
using LibreDteDotNet.SoapRequest.Interfaces;

using Microsoft.Extensions.Configuration;

using ServiceEstadoDte;

using ServiceEstadoDteAv;

using ServiceEstadoDteUp;

namespace LibreDteDotNet.SoapRequest.Services
{
    public class EstadoDteService : ComunEnum, IEstadoDteService
    {
        private readonly IConfiguration configuration;

        public EstadoDteService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<ResEstadoDte.RESPUESTA> GetEstado(
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
                    return Deserializa<ResEstadoDte.RESPUESTA>(response.getEstDteReturn);
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

        public async Task<ResEstadoDteAv.RESPUESTA> GetEstado(
            string RutCompania,
            string DvCompania,
            string RutReceptor,
            string DvReceptor,
            TipoDoc TipoDte,
            string FolioDte,
            string FechaEmisionDte,
            string MontoDte,
            string firma,
            string Token
        )
        {
            QueryEstDteAvClient client = new();
            try
            {
                using OperationContextScope ocs = new(client.InnerChannel);
                HttpRequestMessageProperty prop = new();
                prop.Headers.Add(HttpRequestHeader.Cookie, $"TOKEN={Token}");
                OperationContext.Current.OutgoingMessageProperties.Add(
                    HttpRequestMessageProperty.Name,
                    prop
                );
                var response = await client.getEstDteAvAsync(
                    new getEstDteAvRequest()
                    {
                        RutEmpresa = RutCompania,
                        DvEmpresa = DvCompania,
                        RutReceptor = RutReceptor,
                        DvReceptor = DvReceptor,
                        TipoDte = ((int)TipoDte).ToString(),
                        FolioDte = FolioDte,
                        FechaEmisionDte = FechaEmisionDte,
                        MontoDte = MontoDte,
                        FirmaDte = firma,
                        Token = Token
                    }
                );
                client.Close();
                if (response != null)
                {
                    return Deserializa<ResEstadoDteAv.RESPUESTA>(response.getEstDteAvReturn);
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

        public async Task<ResEstadoDteUp.RESPUESTA> GetEstadoUp(
            string RutCompania,
            string DvCompania,
            string TrackID,
            string Token
        )
        {
            QueryEstUpClient client = new();
            try
            {
                getEstUpResponse response = await client.getEstUpAsync(
                    new getEstUpRequest()
                    {
                        RutCompania = RutCompania,
                        DvCompania = DvCompania,
                        TrackId = TrackID,
                        Token = Token
                    }
                );
                client.Close();
                if (response != null)
                {
                    return Deserializa<ResEstadoDteUp.RESPUESTA>(response.getEstUpReturn);
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
