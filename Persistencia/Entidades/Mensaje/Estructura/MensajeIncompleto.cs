using System;
using EdoUI.DTO;
using Persistencia.Entidades.Mensaje.Estados;

namespace Persistencia.Entidades.Mensaje.Estructura
{
    public class MensajeIncompleto : MensajeDAO
    {
        public MensajeIncompleto(IMensajeDTO pMensajeDTO) : base(pMensajeDTO)
        {
            (this.MensajeDTO as MensajeDTO).Estado = new Visibilidad();
        }
    }
}
