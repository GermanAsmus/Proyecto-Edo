using System;
using System.Collections.Generic;
using EdoUI.Entidades.DTO;
using Dominio.DI;
using Dominio.Entidades.DTO;

namespace Dominio.Entidades.Helper
{
    /// <summary>
    /// La clase tiene como responsabilidad crear el/los mensaje/s que corresponda en cada caso.
    /// </summary>
    public class CreadorMensajes
    {

        public CreadorMensajes()
        {
        }

        private IMensajeDTO AgregarDestinatarios(IMensajeDTO pMensajeDAO, ICollection<ICuentaDTO> pDestinatario)
        {
            foreach (ICuentaDTO destinatario in pDestinatario)
            {
                pMensajeDAO.Destinatario.Add(destinatario);
            }

            return pMensajeDAO;
        }

        #region Crear mensajes incompletos
        /// <summary>
        /// Crea un mensaje incompleto, es decir que no contiene cuerpo ni adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta del usuario, de la cual pertenece el mensaje</param>
        /// <param name="pAsunto">Asunto del mensaje</param>
        /// <param name="pDestinatario">Lista de cuentas destinatarias</param>
        /// <returns>Nuevo mensaje incompleto</returns>
        public IMensajeDTO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario)
        {
            IMensajeDTO iMensajeDTO = new MensajeDTO()
            {
                Cuenta = pCuentaDTO,
                Asunto = pAsunto,
                EstadoVisto = DateTime.Today.ToShortDateString()
            };

            return AgregarDestinatarios(iMensajeDTO, pDestinatario);
        }

        #endregion

        #region Crear mensajes completos

        /// <summary>
        /// Crea un mensaje completo, es decir que cuenta con contenido (cuerpo del mensaje), y que puede tener adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta externa, y es distinta de la cuenta del usuario activo</param>
        /// <returns>Nuevo mensaje completo</returns>
        public IMensajeCompletoDTO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido, ICollection<IAdjuntoDTO> pAdjuntos = null)
        {
            IMensajeCompletoDTO iMensajeCompletoDTO = new MensajeDTO()
            {
                Cuenta = pCuentaDTO,
                Asunto = pAsunto,
                Destinatario = pDestinatario,
                Contenido = pContenido,
                Adjuntos = pAdjuntos,
                EstadoVisto = DateTime.Today.ToShortDateString()
            };

            return AgregarDestinatarios(iMensajeCompletoDTO, pDestinatario) as IMensajeCompletoDTO;
        }

        /// <summary>
        /// Crea un mensaje completo, es decir que cuenta con contenido (cuerpo del mensaje),  y que puede tener adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta perteneciente al usuario activo</param>
        /// <returns>Nuevo mensaje completo</returns>
        public IMensajeCompletoDTO CrearMensaje(ICuentaUsuarioDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido, ICollection<IAdjuntoDTO> pAdjuntos = null)
        {
            if (pCuentaDTO.GetType() == typeof(ICuentaUsuarioDTO))
                throw new InvalidCastException(string.Format("El tipo de {0} no deria ser {1}, sino {2}", nameof(pCuentaDTO), typeof(ICuentaUsuarioDTO), typeof(ICuentaDTO)));

            IMensajeCompletoDTO iMensajeCompletoDTO = new MensajeDTO()
            {
                Cuenta = pCuentaDTO,
                Asunto = pAsunto,
                Contenido = pContenido,
                EstadoEnviado = DateTime.Today.ToShortDateString()
            };

            return AgregarDestinatarios(iMensajeCompletoDTO, pDestinatario) as IMensajeCompletoDTO;
        }

        #endregion

    }
}