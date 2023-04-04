using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;

using ServiceEstadoDteAv;

using ServiceRegistro;

namespace LibreDteDotNet.SoapRequest.Services
{
    public class EstadoDteAvService : IEstadoDteAv
    {
        private getEstDteAvResponse? GetEstDteAvResponse { get; set; }

        public async Task<RESPUESTA> AsObject()
        {
            return await Deserializa<RESPUESTA>(GetEstDteAvResponse!.getEstDteAvReturn);
        }

        public async Task<XDocument> AsXDocument()
        {
            try
            {
                return await Task.Run(() =>
                {
                    return XDocument.Parse(GetEstDteAvResponse!.getEstDteAvReturn);
                });
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<IEstadoDteAv> GetEstado(
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
                getEstDteAvResponse response = await client.getEstDteAvAsync(
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
                    GetEstDteAvResponse = response;
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
            catch (System.Exception)
            {
                client.Abort();
                throw;
            }
            return null!;
        }
    }

    public class RegistroDteService : IRegistroDte
    {
        private respuestaTo? RespuestaTo { get; set; }

        public async Task<IRegistroDte> Ingresar(
            string rutEmisor,
            string dvEmisor,
            TipoDoc TipoDte,
            string FolioDte,
            string Token,
            Accion accion
        )
        {
            RegistroReclamoDteServiceClient client = new();
            try
            {
                using OperationContextScope ocs = new(client.InnerChannel);
                HttpRequestMessageProperty prop = new();
                prop.Headers.Add(HttpRequestHeader.Cookie, $"TOKEN={Token}");
                OperationContext.Current.OutgoingMessageProperties.Add(
                    HttpRequestMessageProperty.Name,
                    prop
                );
                //var response = await client.ingresarAceptacionReclamoDocAsync(
                //    rutEmisor,
                //    dvEmisor,
                //    ((int)TipoDte).ToString(),
                //    FolioDte,
                //    accion.ToString()
                //);
                //client.Close();
                //if (response != null)
                //{
                //    //RespuestaTo = response;
                //    return this;
                //}
            }
            catch (CommunicationException)
            {
                client.Abort();
            }
            catch (TimeoutException)
            {
                client.Abort();
            }
            catch (System.Exception)
            {
                client.Abort();
                throw;
            }
            return null!;
        }

        public async Task<IRegistroDte> Listar(
            string rutEmisor,
            string dvEmisor,
            TipoDoc TipoDte,
            string FolioDte,
            string Token
        )
        {
            RegistroReclamoDteServiceClient client = new();
            using OperationContextScope ocs = new(client.InnerChannel);
            HttpRequestMessageProperty prop = new();
            prop.Headers.Add(HttpRequestHeader.Cookie, $"TOKEN={Token}");
            OperationContext.Current.OutgoingMessageProperties.Add(
                HttpRequestMessageProperty.Name,
                prop
            );
            try
            {
                var response = await client.listarEventosHistDocAsync(
                    rutEmisor,
                    dvEmisor,
                    ((int)TipoDte).ToString(),
                    FolioDte
                );
                client.Close();
                if (response != null)
                {
                    //  RespuestaTo = response;
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
            catch (System.Exception)
            {
                client.Abort();
                throw;
            }
            return null!;
        }
    }
}
