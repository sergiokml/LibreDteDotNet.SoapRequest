namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IEstadoDteUp : IConvert
    {
        Task<IEstadoDteUp> GetEstado(
            string RutCompania,
            string DvCompania,
            string TrackID,
            string Token
        );
    }
}
