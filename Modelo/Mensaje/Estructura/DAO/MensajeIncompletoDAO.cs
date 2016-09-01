using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeIncompletoDAO : MensajeEstructuradoDAO
    {
        public MensajeIncompletoDAO(IMensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
            this.iMensajeEstructuradoDTO = new MensajeIncompletoDTO();
        }

        public override IMensajeDTO MensajeDTO
        {
            get
            {
                return this.iMensajeEstructuradoDTO;
            }

            set
            {
                this.iMensajeEstructuradoDTO = (value as MensajeIncompletoDTO);
            }
        }
    }
}
