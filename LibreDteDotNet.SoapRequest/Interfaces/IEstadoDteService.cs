using System.ComponentModel;
using System.Xml.Linq;

namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IEstadoDteService
    {
        Task<XDocument> GetEstado(
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

        public enum TipoDoc : int
        {
            // S = AFECTO IVA
            [Description("S")]
            FacturaAfectaElectronica = 33,

            [Description("N")]
            FacturaExentaElectronica = 34,

            [Description("S")]
            NotaCreditoElectronica = 61
        }
    }
}
