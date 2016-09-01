using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeUsuario : MensajePertenecienteDAO
    {
        private MensajeUsuarioDTO iMensajeUsuarioDTO;

        public override IMensajeDTO MensajeDTO
        {
            get
            {
                return this.iMensajeUsuarioDTO;
            }

            set
            {
                try
                {
                    this.iMensajeUsuarioDTO = value as MensajeUsuarioDTO;
                }
                catch (Exception ex)
                {

                    throw new MensajeSetException("No se pudo realizar la operación", ex);
                }

            }
        }

        public MensajeUsuario(IMensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
            this.iMensajeUsuarioDTO = new MensajeUsuarioDTO();
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
