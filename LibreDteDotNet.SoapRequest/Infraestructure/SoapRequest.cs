using LibreDteDotNet.SoapRequest.Interfaces;

namespace LibreDteDotNet.SoapRequest.Infraestructure
{
    public class SoapRequest
    {
        public ITokenSeedService TokenSeed { get; }
        public IEstadoDteService EstadoDte { get; }

        public SoapRequest(ITokenSeedService tokenSeedService, IEstadoDteService estadoDte)
        {
            TokenSeed = tokenSeedService;
            EstadoDte = estadoDte;
        }
    }
}
