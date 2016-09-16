using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;

namespace Modelo
{
    /// <summary>
    /// La clase mensajeria tiene como responsabilidad crear el/los mensaje/s que corresponda en cada caso.
    /// </summary>
    public class Mensajeria
    {

        private IMensajeDTO iMensajeDTO;

        public Mensajeria()
        {
        }

        private IMensajeDAO AgregarDestinatarios(IMensajeDAO pMensajeDAO, ICollection<ICuentaDTO> pDestinatario)
        {
            foreach (ICuentaDTO destinatario in pDestinatario)
            {
                pMensajeDAO.Agregar(destinatario);
            }

            return pMensajeDAO;
        }


        #region Crear mensajes incompletos
        /// <summary>
        /// Crea un mensaje incompleto, es decir que no contiene cuerpo ni adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta del usuario, de la cual pertenece el mensaje</param>
        /// <param name="pAsunto">Asunto del mensaje</param>
        /// <param name="pDestinatario">Cuenta destinataria</param>
        /// <returns>Nuevo mensaje incompleto</returns>
        public IMensajeDAO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICuentaDTO pDestinatario)
        {
            this.iMensajeDTO = new MensajeDTO()
            {
                Cuenta = pCuentaDTO,
                Asunto = pAsunto,
            };

            return AgregarDestinatarios(new MensajeIncompleto(this.iMensajeDTO), new List<ICuentaDTO>() { pDestinatario });
        }

        /// <summary>
        /// Crea un mensaje incompleto, es decir que no contiene cuerpo ni adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta del usuario, de la cual pertenece el mensaje</param>
        /// <param name="pAsunto">Asunto del mensaje</param>
        /// <param name="pDestinatario">Lista de cuentas destinatarias</param>
        /// <returns>Nuevo mensaje incompleto</returns>
        public IMensajeDAO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario)
        {
            this.iMensajeDTO = new MensajeDTO()
            {
                Cuenta = pCuentaDTO,
                Asunto = pAsunto,
            };

            return AgregarDestinatarios(new MensajeIncompleto(this.iMensajeDTO), pDestinatario);
        }

        #endregion

        #region Crear mensajes completos

        /// <summary>
        /// Crea un mensaje con cuerpo, es decir que cuenta con contenido (cuerpo del mensaje), pero no adjuntos.
        /// </summary>
        /// <returns>Nuevo mensaje completo</returns>
        public IMensajeCompletoDAO CrearMensaje(ICuentaUsuarioDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido)
        {
            this.iMensajeDTO = this.CrearMensajeDTO(pCuentaDTO, pAsunto, pDestinatario, pContenido);

            return AgregarDestinatarios(new MensajeCompleto(this.iMensajeDTO as IMensajeCompletoDTO), pDestinatario) as IMensajeCompletoDAO;
        }
        /// <summary>
        /// Crea un mensaje completo, es decir que cuenta con contenido (cuerpo del mensaje), y adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta externa, y es distinta de la cuenta del usuario activo</param>
        /// <returns>Nuevo mensaje completo</returns>
        public IMensajeCompletoDAO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido, ICollection<IAdjuntoDTO> pAdjuntos)
        {
            this.iMensajeDTO = this.CrearMensajeDTO(pCuentaDTO, pAsunto, pDestinatario, pContenido, pAdjuntos);

            return AgregarDestinatarios(new MensajeCompleto(this.iMensajeDTO as IMensajeCompletoDTO), pDestinatario) as IMensajeCompletoDAO;
        }

        /// <summary>
        /// Crea un mensaje completo, es decir que cuenta con contenido (cuerpo del mensaje), y adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta perteneciente al usuario activo</param>
        /// <returns>Nuevo mensaje completo</returns>
        public IMensajeCompletoDAO CrearMensaje(ICuentaUsuarioDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido, ICollection<IAdjuntoDTO> pAdjuntos)
        {
            this.iMensajeDTO = this.CrearMensajeDTO(pCuentaDTO, pAsunto, pDestinatario, pContenido, pAdjuntos);

            return AgregarDestinatarios(new MensajeCompleto(this.iMensajeDTO as IMensajeCompletoDTO), pDestinatario) as IMensajeCompletoDAO;
        }

        private IMensajeCompletoDTO CrearMensajeDTO(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido)
        {
            if (pCuentaDTO.GetType() == typeof(ICuentaUsuarioDTO))
                throw new InvalidCastException(string.Format("El tipo de {0} no deria ser {1}, sino {2}", nameof(pCuentaDTO), typeof(ICuentaUsuarioDTO), typeof(ICuentaDTO)));

            IMensajeCompletoDTO iMensajeCompletoDTO = new MensajeDTO();
            iMensajeCompletoDTO.Cuenta = pCuentaDTO;
            iMensajeCompletoDTO.Asunto = pAsunto;
            iMensajeCompletoDTO.Contenido = pContenido;
            (iMensajeCompletoDTO as MensajeDTO).Estado = new Comunicacion();
            return iMensajeCompletoDTO;
        }

        private IMensajeCompletoDTO CrearMensajeDTO(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido, ICollection<IAdjuntoDTO> pAdjuntos)
        {
            IMensajeCompletoDTO iMensajeCompletoDTO = new MensajeDTO();
            iMensajeCompletoDTO.Cuenta = pCuentaDTO;
            iMensajeCompletoDTO.Asunto = pAsunto;
            iMensajeCompletoDTO.Destinatario = pDestinatario;
            iMensajeCompletoDTO.Contenido = pContenido;
            iMensajeCompletoDTO.Adjuntos = pAdjuntos;
            (iMensajeCompletoDTO as MensajeDTO).Estado = new Visibilidad();
            return iMensajeCompletoDTO;
        }

        #endregion

    }
}