using EdoUI.DTO;
using System;

namespace Persistencia.Repositorios.CriteriosDeBusqueda
{
    public class BuscarMensaje : CriterioDeBusqueda<IMensajeDTO>
    {
        public new static Func<IMensajeDTO, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IMensajeDTO, string, bool> BuscarPorAsunto = (pEntidad, pAsunto) => pEntidad.Asunto == pAsunto;
    }
}
