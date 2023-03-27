using LibreDteDotNet.SoapRequest.Interfaces;

namespace LibreDteDotNet.RestRequest.Infraestructure
{
    public class SoapRequest
    {
        public ITokenSeedService TokenSeedService { get; }

        public SoapRequest(ITokenSeedService tokenSeedService)
        {
            TokenSeedService = tokenSeedService;
        }
    }
}
