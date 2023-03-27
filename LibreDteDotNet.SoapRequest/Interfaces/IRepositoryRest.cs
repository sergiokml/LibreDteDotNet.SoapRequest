namespace LibreDteDotNet.RestRequest.Interfaces
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
