using EdoUI.DTO;
using Dominio.Entidades.DAO;
using System;
using System.Collections.Generic;
using Persistencia.Entidades.Cuenta.Pertenencia;

namespace Persistencia.Entidades.Cuenta
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
                pCuenta.Agregar(mensaje);
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
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta)); 
            #endregion

            this.iCuentaDTO = new CuentaDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta)
            };
            return new CuentaExterna(iCuentaDTO);
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
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta));

            if (pMensajes == null)
                throw new NullReferenceException(nameof(pMensajes)); 
            #endregion

            this.iCuentaDTO = new CuentaDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta),
            };

            return this.AgregarMensajes(new CuentaExterna(iCuentaDTO), pMensajes);
        }

        #endregion

        #region Crear cuenta usuario
        private ICuentaDAO AgregarMensajes(ICuentaDAO pCuenta, ICollection<IMensajeCompletoDTO> pMensajes)
        {
            foreach (IMensajeCompletoDTO mensaje in pMensajes)
            {
                (pCuenta as CuentaUsuario).Agregar(mensaje);
            }
            return pCuenta;
        }

        /// <summary>
        /// Crea una cuenta de usuario, definiendo la direccion de correo asociada, el nombre y la contraseña.
        /// </summary>
        /// <param name="pDireccionCuenta">Direccion de correo asociada a la cuenta.</param>
        /// <param name="pContraseña">Contraseña de la cuenta.</param>
        /// <param name="pNombre">Tipo que identifica a la cuenta.</param>
        /// <returns>Nueva cuenta de usuario.</returns>
        public ICuentaDAO CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre)
        {
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta));

            if (string.IsNullOrEmpty(pContraseña))
                throw new NullReferenceException(nameof(pContraseña));

            if (string.IsNullOrEmpty(pNombre))
                throw new NullReferenceException(nameof(pNombre)); 
            #endregion

            this.iCuentaDTO = new CuentaUsuarioDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta),
                Nombre = pNombre,
                Contraseña = pContraseña
            };

            return new CuentaUsuario(this.iCuentaDTO as ICuentaUsuarioDTO);
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
        public ICuentaDAO CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre, ICollection<IMensajeCompletoDTO> pMensajes)
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

            this.iCuentaDTO = new CuentaUsuarioDTO()
            {
                DireccionCorreo = new DireccionCorreoDTO(pDireccionCuenta),
                Nombre = pNombre,
                Contraseña = pContraseña
            };

            return this.AgregarMensajes(new CuentaUsuario(this.iCuentaDTO as ICuentaUsuarioDTO), pMensajes);
        } 
        #endregion
    }

}