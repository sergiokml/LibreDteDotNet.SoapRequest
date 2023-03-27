namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface ITokenSeedService
    {
        Task<string> GetToken(string rut);
    }
}
