namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IEstadoDteService
    {
        Task<string> GetEstado(
            string RutConsultante,
            string DvConsultante,
            string RutCompania,
            string DvCompania,
            string RutReceptor,
            string DvReceptor,
            string TipoDte,
            string FolioDte,
            string FechaEmisionDte,
            string MontoDte,
            string Token
        );
    }
}
