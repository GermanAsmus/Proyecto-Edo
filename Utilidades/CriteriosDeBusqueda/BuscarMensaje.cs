using CapaInterfaces.Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarMensaje : CriterioDeBusqueda<IMensaje>
    {
        public new static Func<IMensaje, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IMensaje, string, bool> BuscarPorAsunto = (pEntidad, pAsunto) => pEntidad.Asunto == pAsunto;
    }
}
