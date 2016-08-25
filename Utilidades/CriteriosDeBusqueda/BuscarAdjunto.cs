using CapaInterfaces.Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public abstract class BuscarAdjunto : CriterioDeBusqueda<IAdjunto>
    {
        public new static Func<IAdjunto, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IAdjunto, string, bool> BuscarPorCodigo = (pEntidad, pCodigo) => pEntidad.CodigoAdjunto == pCodigo;
    }
}
