using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

using LibreDteDotNet.SoapRequest.Interfaces;

using ServiceEstadoDte;

namespace LibreDteDotNet.SoapRequest.Services
{
    public class SecurityTokenMessageInspector : IClientMessageInspector
    {
        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            request.Headers.Add(MessageHeader.CreateHeader("myToken", string.Empty, ""));
            return null;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState) { }
    }

    public class EstadoDteService : IEstadoDteService
    {
        public async Task<string> GetEstado(
            string RutConsultante,
            string DvConsultante,
            string RutCompania,
            string DvCompania,
            string RutReceptor,
            string DvReceptor,
            string TipoDte,
            string FolioDte,
            string FechaEmisionDte,
            string MontoDte,
            string Token
        )
        {
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
                        RutConsultante = RutConsultante,
                        DvConsultante = DvConsultante,
                        RutReceptor = RutReceptor,
                        DvReceptor = DvReceptor,
                        TipoDte = TipoDte,
                        MontoDte = MontoDte,
                        FechaEmisionDte = FechaEmisionDte,
                        DvCompania = DvCompania,
                        FolioDte = FolioDte,
                        RutCompania = RutCompania,
                        Token = Token
                    }
                );
                client.Close();
                if (response != null)
                {
                    //
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
