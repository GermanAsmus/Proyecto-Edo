using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    public class MensajeExterno : MensajePertenecienteDAO
    {
        public MensajeExterno(IMensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
            this.iMensajeExternoDTO = new MensajeExternoDTO();
            (this.MensajeDTO as MensajeExternoDTO).EstadoVisibilidad = new KeyValuePair<DateTime, EstadoVisibilidad>(DateTime.Today, EstadoVisibilidad.No_Visto);
        }

        private MensajeExternoDTO iMensajeExternoDTO;

        public override IMensajeDTO MensajeDTO
        {
            get
            {
                return this.iMensajeExternoDTO;
            }

            set
            {
                try
                {
                    this.iMensajeExternoDTO = value as MensajeExternoDTO;
                }
                catch (Exception ex)
                {

                    throw new MensajeSetException("No se pudo realizar la operación", ex);
                }

            }
        }

        //Cambia el estado de la visibilidad del mensaje, agregando el cambio como un nuevo registro.
        private void CambiarEstadoVisibilidad(EstadoVisibilidad pVisibilidad)
        {
            (this.MensajeDTO as MensajeExternoDTO).EstadoVisibilidad = new KeyValuePair<DateTime, EstadoVisibilidad>(DateTime.Today,pVisibilidad);
        }
        //Cambia el estado de la visibilidad del mensaje.
        public EstadoVisibilidad CambiarEstadoVisibilidad()
        {
            if (this.ObtenerEstadoVisibilidad() != EstadoVisibilidad.Visto)
                this.CambiarEstadoVisibilidad(EstadoVisibilidad.Visto);
            else
                this.CambiarEstadoVisibilidad(EstadoVisibilidad.No_Visto);

            return this.ObtenerEstadoVisibilidad();
        }
        //Se devuelve el estado de visibilidad del mensaje.
        public EstadoVisibilidad ObtenerEstadoVisibilidad()
        {
            return (this.MensajeDTO as MensajeExternoDTO).EstadoVisibilidad.Value;
        }
        //Se devuelve si el mensaje es externo o del usuario.
        public override EstrategiaPertenencia ObtenerPertenencia()
        {
            return EstrategiaPertenencia.Externo;
        }
    }
}
