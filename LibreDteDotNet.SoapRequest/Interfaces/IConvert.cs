namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IConvert
    {
        Task<RESPUESTA> AsObject();
        Task<XDocument> AsXDocument();
    }
}
