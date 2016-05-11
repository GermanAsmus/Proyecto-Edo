using Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public abstract class BuscarAdjunto : CriterioDeBusqueda<Adjunto>
    {
        public new static Func<Adjunto, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<Adjunto, string, bool> BuscarPorCodigo = (pEntidad, pCodigo) => pEntidad.CodigoAdjunto == pCodigo;
    }
}
