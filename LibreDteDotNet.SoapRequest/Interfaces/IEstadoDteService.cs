using System.ComponentModel;
using System.Xml.Linq;

using LibreDteDotNet.Common.Models;

using static LibreDteDotNet.Common.ComunEnum;

namespace LibreDteDotNet.SoapRequest.Interfaces
{
    public interface IEstadoDteService
    {
        Task<ResEstadoDte.RESPUESTA> GetEstado(
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
        Task<ResEstadoDteAv.RESPUESTA> GetEstado(
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
        Task<ResEstadoDteUp.RESPUESTA> GetEstadoUp(
            string RutCompania,
            string DvCompania,
            string TrackID,
            string Token
        );
    }
}
