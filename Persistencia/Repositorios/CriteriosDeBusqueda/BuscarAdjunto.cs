using EdoUI.DTO;
using System;

namespace Persistencia.Repositorios.CriteriosDeBusqueda
{
    public abstract class BuscarAdjunto : CriterioDeBusqueda<IAdjuntoDTO>
    {
        public new static Func<IAdjuntoDTO, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IAdjuntoDTO, string, bool> BuscarPorCodigo = (pEntidad, pCodigo) => pEntidad.PathAdjunto == pCodigo;
    }
}
