using System;
using CapaInterfaces.Modelo;

namespace Persistencia
{
    public class MensajeIncompleto : MensajeDAO
    {
        public MensajeIncompleto(IMensajeDTO pMensajeDTO) : base(pMensajeDTO)
        {
            (this.MensajeDTO as MensajeDTO).Estado = new Visibilidad();
        }
    }
}
