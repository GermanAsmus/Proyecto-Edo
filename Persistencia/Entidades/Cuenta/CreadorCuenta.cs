using EdoUI.DTO;
using Dominio.Entidades.DAO;
using System;
using System.Collections.Generic;
//using Persistencia.Entidades.Cuenta.Pertenencia;

namespace Persistencia.Entidades.Cuenta
{
    public class CreadorCuenta
    {
        #region Crear cuenta externa

        private ICuentaDTO AgregarMensajes(ICuentaDTO pCuenta, ICollection<IMensajeDTO> pMensajes)
        {
            foreach (IMensajeDTO mensaje in pMensajes)
            {
                pCuenta.Mensajes.Add(mensaje);
            }
            return pCuenta;
        }

        /// <summary>
        /// Crea una cuenta externa (distinta a la del usuario), definiendo unicamente la direccion de correo asociada.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <returns>Nueva cuenta extena.</returns>
        public ICuentaDTO CrearCuenta(string pDireccionCuenta)
        {
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta)); 
            #endregion

            return new CuentaDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta)
            };
        }

        /// <summary>
        /// Crea una cuenta externa (distinta a la del usuario), definiendo la direccion de correo asociada
        /// y los mensajes correspondientes a la cuenta.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pMensajes">Mensajes correspondientes a la cuenta.</param>
        /// <returns>Nueva cuenta externa.</returns>
        public ICuentaDTO CrearCuenta(string pDireccionCuenta, ICollection<IMensajeDTO> pMensajes)
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

            return this.AgregarMensajes(iCuentaDTO, pMensajes);
        }

        #endregion

        #region Crear cuenta usuario
        private ICuentaUsuarioDTO AgregarMensajes(ICuentaDTO pCuenta, ICollection<IMensajeCompletoDTO> pMensajes)
        {
            foreach (IMensajeCompletoDTO mensaje in pMensajes)
            {
                pCuenta.Mensajes.Add(mensaje);
            }
            return pCuenta as ICuentaUsuarioDTO;
        }

        /// <summary>
        /// Crea una cuenta de usuario, definiendo la direccion de correo asociada, el nombre y la contraseña.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pContraseña">Contraseña de la cuenta.</param>
        /// <param name="pNombre">Tipo que identifica a la cuenta.</param>
        /// <returns>Nueva cuenta de usuario.</returns>
        public ICuentaUsuarioDTO CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre)
        {
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta));

            if (string.IsNullOrEmpty(pContraseña))
                throw new NullReferenceException(nameof(pContraseña));

            if (string.IsNullOrEmpty(pNombre))
                throw new NullReferenceException(nameof(pNombre)); 
            #endregion

            return new CuentaUsuarioDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta),
                Nombre = pNombre,
                Contraseña = pContraseña
            };
        }

        /// <summary>
        /// Crea una cuenta de usuario, definiendo la direccion de correo asociada, el nombre, la contraseña
        /// y los mensajes correspondientes a la cuenta.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pContraseña">Contraseña de la cuenta.</param>
        /// <param name="pNombre">Tipo que identifica a la cuenta.</param>
        /// <param name="pMensajes">Mensajes correspondientes a la cuenta.</param>
        /// <returns>Nueva cuenta de usuario.</returns>
        public ICuentaUsuarioDTO CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre, ICollection<IMensajeCompletoDTO> pMensajes)
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

            return this.AgregarMensajes(iCuentaDTO, pMensajes) as ICuentaUsuarioDTO;
        } 
        #endregion
    }

}