using CapaInterfaces.Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarMensaje : CriterioDeBusqueda<IMensajeDTO>
    {
        public new static Func<IMensajeDTO, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IMensajeDTO, string, bool> BuscarPorAsunto = (pEntidad, pAsunto) => pEntidad.Asunto == pAsunto;
    }
}
