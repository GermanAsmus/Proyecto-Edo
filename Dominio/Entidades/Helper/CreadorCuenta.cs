using System;
using System.Collections.Generic;
using EdoUI.Entidades.DTO;
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
        public ICuenta CrearCuenta(string pDireccionCuenta, ICollection<IMensaje> pMensajes = null)
        {
            #region programacion defensiva
            if (string.IsNullOrEmpty(pDireccionCuenta))
                throw new NullReferenceException(nameof(pDireccionCuenta));

            if (pMensajes == null)
                throw new NullReferenceException(nameof(pMensajes));
            #endregion

            ICuenta iCuentaDTO = new Entidades.Cuenta()
            {
                DireccionCorreo = new DireccionCorreo(pDireccionCuenta),
            };
            if(pMensajes!=null)
                foreach (IMensaje mensaje in pMensajes)
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
        public ICuenta CrearCuenta(string pDireccionCuenta, string pContraseña, string pNombre, ICollection<IMensaje> pMensajes = null)
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

            ICuenta iCuentaDTO = new Cuenta()
            {
                DireccionCorreo = new DireccionCorreo(pDireccionCuenta),
                Nombre = pNombre,
                Contraseña = pContraseña
            };

            if(pMensajes!=null)
                foreach (IMensaje mensaje in pMensajes)
                {
                    iCuentaDTO.Mensajes.Add(mensaje);
                }

            return iCuentaDTO;
        } 
        
        #endregion
    }

}