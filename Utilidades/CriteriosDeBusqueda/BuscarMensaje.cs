using Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarMensaje : CriterioDeBusqueda<Mensaje>
    {
        public new static Func<Mensaje, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<Mensaje, string, bool> BuscarPorCodigo = (pEntidad, pCodigo) => pEntidad.CodigoMensaje == pCodigo;
        public static Func<Mensaje, string, bool> BuscarPorAsunto = (pEntidad, pAsunto) => pEntidad.Asunto == pAsunto;
    }
}
