using CapaInterfaces.Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public abstract class BuscarAdjunto : CriterioDeBusqueda<IAdjuntoDTO>
    {
        public new static Func<IAdjuntoDTO, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IAdjuntoDTO, string, bool> BuscarPorCodigo = (pEntidad, pCodigo) => pEntidad.PathAdjunto == pCodigo;
    }
}
