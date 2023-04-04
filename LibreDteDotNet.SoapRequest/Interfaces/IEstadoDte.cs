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
}
