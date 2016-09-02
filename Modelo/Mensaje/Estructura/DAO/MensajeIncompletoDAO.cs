using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeIncompletoDAO : MensajeEstructuradoDAO
    {
        public MensajeIncompletoDAO(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
        }

        public override IMensajeDTO MensajeDTO
        {
            get
            {
                return base.MensajeDTO as MensajeIncompletoDTO;
            }

            set
            {
                base.MensajeDTO = value as MensajeIncompletoDTO;
            }
        }
    }
}
