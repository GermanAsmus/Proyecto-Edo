﻿using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    // {Cuentero, AdministradorCuentas, CuentaManager}
    public class CreadorCuenta
    {
        private ICuentaDTO iCuentaDTO;

        #region Crear cuenta externa

        private ICuentaDAO AgregarMensajes(ICuentaDAO pCuenta, ICollection<IMensajeDTO> pMensajes)
        {
            foreach (IMensajeDTO mensaje in pMensajes)
            {
                (pCuenta as CuentaDAO).Agregar(mensaje);
            }
            return pCuenta;
        }

        /// <summary>
        /// Crea una cuenta externa (distinta a la del usuario), definiendo unicamente la direccion de correo asociada.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <returns>Nueva cuenta extena.</returns>
        public ICuentaDAO CrearCuenta(string pDireccionCuenta)
        {
            this.iCuentaDTO = new CuentaDTO()
            {
                DireccionCorreo = new DireccionCorreo(pDireccionCuenta)
            };
            return new CuentaExternaDAO(iCuentaDTO);
        }

        /// <summary>
        /// Crea una cuenta externa (distinta a la del usuario), definiendo la direccion de correo asociada
        /// y los mensajes correspondientes a la cuenta.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pMensajes">Mensajes correspondientes a la cuenta.</param>
        /// <returns>Nueva cuenta externa.</returns>
        public ICuentaDAO CrearCuenta(string pDireccionCuenta, ICollection<IMensajeDTO> pMensajes)
        {
            this.iCuentaDTO = new CuentaDTO()
            {
                DireccionCorreo = new DireccionCorreo(pDireccionCuenta),
            };

            return this.AgregarMensajes(new CuentaExternaDAO(iCuentaDTO), pMensajes);
        }

        #endregion

        #region Crear cuenta usuario
        private ICuentaDAO AgregarMensajes(ICuentaDAO pCuenta, ICollection<IMensajeCompletoDTO> pMensajes)
        {
            foreach (IMensajeCompletoDTO mensaje in pMensajes)
            {
                (pCuenta as CuentaUsuarioDAO).Agregar(mensaje);
            }
            return pCuenta;
        }

        /// <summary>
        /// Crea una cuenta de usuario, definiendo la direccion de correo asociada, el nombre y la contraseña.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pContraseña">Contraseña de la cuenta.</param>
        /// <param name="pNombre">Nombre que identifica a la cuenta.</param>
        /// <returns>Nueva cuenta de usuario.</returns>
        public ICuentaDAO CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre)
        {
            this.iCuentaDTO = new CuentaUsuarioDTO()
            {
                DireccionCorreo = new DireccionCorreo(pDireccionCuenta),
                Nombre = pNombre,
                Contraseña = pContraseña
            };

            return new CuentaUsuarioDAO(this.iCuentaDTO as ICuentaUsuarioDTO);
        }

        /// <summary>
        /// Crea una cuenta de usuario, definiendo la direccion de correo asociada, el nombre, la contraseña
        /// y los mensajes correspondientes a la cuenta.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pContraseña">Contraseña de la cuenta.</param>
        /// <param name="pNombre">Nombre que identifica a la cuenta.</param>
        /// <param name="pMensajes">Mensajes correspondientes a la cuenta.</param>
        /// <returns>Nueva cuenta de usuario.</returns>
        public ICuentaDAO CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre, ICollection<IMensajeCompletoDTO> pMensajes)
        {
            this.iCuentaDTO = new CuentaUsuarioDTO()
            {
                DireccionCorreo = new DireccionCorreo(pDireccionCuenta),
                Nombre = pNombre,
                Contraseña = pContraseña
            };

            return this.AgregarMensajes(new CuentaUsuarioDAO(this.iCuentaDTO as ICuentaUsuarioDTO), pMensajes);
        } 
        #endregion
    }

}