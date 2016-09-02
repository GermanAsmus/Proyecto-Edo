using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class CreadorCuentaUsuario : CreadorCuenta
    {
        public CreadorCuentaUsuario(string pDireccion, string pContraseña, string pNombre, ICollection<IMensajeDTO> pMensajes) : base(pDireccion, pMensajes)
        {
            this.iCuentaDTO = new CuentaUsuarioDTO()
            {
                DireccionCorreo = new DireccionCorreo(pDireccion),
                Nombre = pNombre,
                Contraseña = pContraseña,
                Mensajes = pMensajes
            };
        }

        protected override ICuentaDTO iCuentaDTO
        {
            get
            {
                return base.iCuentaDTO as ICuentaUsuarioDTO;
            }

            set
            {
                base.iCuentaDTO = value as ICuentaUsuarioDTO;
            }
        }

        protected override ICuentaDAO CrearEntidad()
        {
            return new CuentaUsuarioDAO(this.iCuentaDTO);
        }
    }
}