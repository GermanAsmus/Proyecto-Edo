using System;
using System.Collections.Generic;
using EdoUI.Entidades.DTO;
using Dominio.Entidades.DTO;
//using Persistencia.Entidades.Cuenta.Pertenencia;

namespace Dominio.Entidades.Helper
{
    public class CreadorCuenta
    {
        #region Crear cuenta externa

        /// <summary>
        /// Crea una cuenta externa (distinta a la del usuario), definiendo la direccion de correo asociada
        /// [y los posibles mensajes correspondientes a la cuenta].
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pMensajes">Mensajes correspondientes a la cuenta.</param>
        /// <returns>Nueva cuenta externa.</returns>
        public ICuentaDTO CrearCuenta(string pDireccionCuenta, ICollection<IMensajeDTO> pMensajes = null)
        {
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta));

            if (pMensajes == null)
                throw new NullReferenceException(nameof(pMensajes)); 
            #endregion

            ICuentaDTO iCuentaDTO = new CuentaDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta),
            };
            if(pMensajes!=null)
                foreach (IMensajeDTO mensaje in pMensajes)
                {
                    iCuentaDTO.Mensajes.Add(mensaje);
                }

            return iCuentaDTO;
        }

        #endregion

        #region Crear cuenta usuario

        /// <summary>
        /// Crea una cuenta de usuario, definiendo la direccion de correo asociada, el nombre, la contraseña
        /// [y los posibles mensajes correspondientes a la cuenta].
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pContraseña">Contraseña de la cuenta.</param>
        /// <param name="pNombre">Tipo que identifica a la cuenta.</param>
        /// <param name="pMensajes">Mensajes correspondientes a la cuenta.</param>
        /// <returns>Nueva cuenta de usuario.</returns>
        public ICuentaUsuarioDTO CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre, ICollection<IMensajeCompletoDTO> pMensajes = null)
        {
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta));

            if (string.IsNullOrEmpty(pContraseña))
                throw new NullReferenceException(nameof(pContraseña));

            if (string.IsNullOrEmpty(pNombre))
                throw new NullReferenceException(nameof(pNombre));

            if (pMensajes == null)
                throw new NullReferenceException(nameof(pMensajes)); 
            #endregion

            ICuentaUsuarioDTO iCuentaDTO = new CuentaUsuarioDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta),
                Nombre = pNombre,
                Contraseña = pContraseña
            };

            if(pMensajes!=null)
                foreach (IMensajeCompletoDTO mensaje in pMensajes)
                {
                    iCuentaDTO.Mensajes.Add(mensaje);
                }

            return iCuentaDTO;
        } 
        
        #endregion
    }

}