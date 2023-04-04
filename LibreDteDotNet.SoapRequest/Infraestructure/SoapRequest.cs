global using System.Xml.Linq;

global using LibreDteDotNet.SoapRequest.Interfaces;

global using static LibreDteDotNet.Common.ComunEnum;
global using static LibreDteDotNet.Common.Models.ResEstadoDte;

namespace LibreDteDotNet.SoapRequest.Infraestructure
{
    public class SoapRequest
    {
        public ITokenSeed TokenSeed { get; }
        public IEstadoDte EstadoDte { get; }
        public IEstadoDteUp EstadoDteUp { get; }
        public IEstadoDteAv EstadoDteAv { get; }
        public IRegistroDte RegistroDte { get; set; }

        public SoapRequest(
            ITokenSeed tokenSeed,
            IEstadoDte estadoDte,
            IEstadoDteUp estadoDteUp,
            IEstadoDteAv estadoDteAv,
            IRegistroDte registroDte
        )
        {
            TokenSeed = tokenSeed;
            EstadoDte = estadoDte;
            EstadoDteUp = estadoDteUp;
            EstadoDteAv = estadoDteAv;
            RegistroDte = registroDte;
        }
    }
}
