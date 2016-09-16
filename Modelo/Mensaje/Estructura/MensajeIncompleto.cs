using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeIncompleto : MensajeDAO
    {
        public MensajeIncompleto(IMensajeDTO pMensajeDTO) : base(pMensajeDTO)
        {
            (this.MensajeDTO as MensajeDTO).Estado = new Visibilidad();
        }
    }
}
