namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IEstadoDteAv : IConvert
    {
        Task<IEstadoDteAv> GetEstado(
            string RutCompania,
            string DvCompania,
            string RutReceptor,
            string DvReceptor,
            TipoDoc TipoDte,
            string FolioDte,
            string FechaEmisionDte,
            string MontoDte,
            string firma,
            string Token
        );
    }
}
