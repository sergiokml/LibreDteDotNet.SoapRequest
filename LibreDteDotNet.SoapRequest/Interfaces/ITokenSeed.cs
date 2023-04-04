namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface ITokenSeed
    {
        Task<string> GetToken(string rut);
    }
}
