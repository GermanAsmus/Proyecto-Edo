using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeUsuario : MensajePertenecienteDAO
    {
        public override IMensajeDTO MensajeDTO
        {
            get
            {
                return base.MensajeDTO as MensajeUsuarioDTO;
            }

            set
            {
                    base.MensajeDTO = value as MensajeUsuarioDTO;
            }
        }

        public MensajeUsuario(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
            (this.MensajeDTO as MensajeUsuarioDTO).EstadoComunicacion = new KeyValuePair<DateTime, EstadoComunicacion>(DateTime.Today, EstadoComunicacion.No_Enviado);
        }

        private void CambiarEstadoComunicacion(EstadoComunicacion pComunicacion)
        {
            (this.MensajeDTO as MensajeUsuarioDTO).EstadoComunicacion = new KeyValuePair<DateTime, EstadoComunicacion>(DateTime.Today,pComunicacion);
        }

        public EstadoComunicacion CambiarEstadoComunicacion()
        {
            if (this.ObtenerEstadoComunicacion() != EstadoComunicacion.Enviado)
                this.CambiarEstadoComunicacion(EstadoComunicacion.Enviado);
            else
                this.CambiarEstadoComunicacion(EstadoComunicacion.No_Enviado);

            return this.ObtenerEstadoComunicacion();
        }

        public EstadoComunicacion ObtenerEstadoComunicacion()
        {
            return (this.MensajeDTO as MensajeUsuarioDTO).EstadoComunicacion.Value;
        }

        public override EstrategiaPertenencia ObtenerPertenencia()
        {
            return EstrategiaPertenencia.Usuario;
        }
    }
}
