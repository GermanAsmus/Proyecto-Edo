using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeNulo : MensajeEstructuradoDAO
    {

        public MensajeNulo(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
        }

        public override IMensajeDTO MensajeDTO
        {
            get
            {
                return base.MensajeDTO as MensajeNuloDTO;
            }

            set
            {
                base.MensajeDTO = value as MensajeNuloDTO;
            }
        }
    }
}