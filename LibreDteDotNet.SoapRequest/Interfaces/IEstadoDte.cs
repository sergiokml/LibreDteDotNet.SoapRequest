namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IEstadoDte : IConvert
    {
        Task<IEstadoDte> GetEstado(
            string RutCompania,
            string DvCompania,
            string RutReceptor,
            string DvReceptor,
            TipoDoc TipoDte,
            string FolioDte,
            string FechaEmisionDte,
            string MontoDte,
            string Token
        );
    }

    public interface IRegistroDte
    {
        Task<IRegistroDte> Ingresar(
            string RutCompania,
            string DvCompania,
            TipoDoc TipoDte,
            string FolioDte,
            string Token,
            Accion accion
        );
        Task<IRegistroDte> Listar(
            string rutEmisor,
            string dvEmisor,
            TipoDoc TipoDte,
            string FolioDte,
            string Token
        );
    }
}
