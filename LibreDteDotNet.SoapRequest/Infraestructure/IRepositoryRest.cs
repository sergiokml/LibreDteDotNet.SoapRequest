namespace LibreDteDotNet.SoapRequest.Infraestructure
{
    internal interface IRepositoryRest
    {
        Task<HttpResponseMessage>? PostJson(
            string json,
            string url,
            string token,
            CancellationToken canceltkn
        );
    }
}
