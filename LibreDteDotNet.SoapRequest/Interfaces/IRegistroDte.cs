using ServiceRegistro;

namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IRegistroDte
    {
        Task<respuestaTo> IngresarAccion(
            string RutCompania,
            string DvCompania,
            TipoDoc TipoDte,
            string FolioDte,
            string Token,
            Accion accion
        );
        Task<respuestaTo> ListarEventos(
            string rutEmisor,
            string dvEmisor,
            TipoDoc TipoDte,
            string FolioDte,
            string Token
        );
    }
}
