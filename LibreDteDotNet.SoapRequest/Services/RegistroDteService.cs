using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;

using ServiceRegistro;

namespace LibreDteDotNet.SoapRequest.Services
{
    public class RegistroDteService : IRegistroDte
    {
        public async Task<respuestaTo> IngresarAccion(
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
                respuestaTo response = await client.ingresarAceptacionReclamoDocAsync(
                    rutEmisor,
                    dvEmisor,
                    ((int)TipoDte).ToString(),
                    FolioDte,
                    accion.ToString()
                );
                client.Close();
                if (response != null)
                {
                    return response;
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

        public async Task<respuestaTo> ListarEventos(
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
                respuestaTo response = await client.listarEventosHistDocAsync(
                    rutEmisor,
                    dvEmisor,
                    ((int)TipoDte).ToString(),
                    FolioDte
                );
                client.Close();
                if (response != null)
                {
                    return response;
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
