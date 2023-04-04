using System.ServiceModel;

using ServiceEstadoDteUp;

namespace LibreDteDotNet.SoapRequest.Services
{
    public class EstadoDteUpService : IEstadoDteUp
    {
        private getEstUpResponse? GetEstUpResponse { get; set; }

        public async Task<RESPUESTA> AsObject()
        {
            return await Deserializa<RESPUESTA>(GetEstUpResponse!.getEstUpReturn);
        }

        public async Task<XDocument> AsXDocument()
        {
            try
            {
                return await Task.Run(() =>
                {
                    return XDocument.Parse(GetEstUpResponse!.getEstUpReturn);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEstadoDteUp> GetEstado(
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
                    GetEstUpResponse = response;
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
    }
}
