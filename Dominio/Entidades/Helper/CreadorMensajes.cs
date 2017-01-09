using System;
using System.Collections.Generic;
using EdoUI.Entidades.DTO;

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

        private IMensaje AgregarDestinatarios(IMensaje pMensajeDTO, ICollection<ICuenta> pDestinatario)
        {
            foreach (ICuenta destinatario in pDestinatario)
            {
                pMensajeDTO.Destinatario.Add(destinatario);
            }

            return pMensajeDTO;
        }

        /// <summary>
        /// Crea un mensaje completo, es decir que cuenta con contenido (cuerpo del mensaje),  y que puede tener adjuntos asociados.
        /// </summary>
        /// <param name="pCuentaDTO"></param>
        /// <returns>Nuevo mensaje completo</returns>
        public IMensaje CrearMensaje(ICuenta pCuentaDTO, string pAsunto, ICollection<ICuenta> pDestinatario, string pContenido = "", ICollection<IAdjunto> pAdjuntos = null)
        {
            if (pCuentaDTO.GetType() == typeof(ICuenta))
                throw new InvalidCastException(string.Format("El tipo de {0} no deria ser {1}, sino {2}", nameof(pCuentaDTO), typeof(ICuenta), typeof(ICuenta)));

            IMensaje iMensajeCompletoDTO = new Entidades.Mensaje()
            {
                Cuenta = pCuentaDTO,
                Asunto = pAsunto,
                Contenido = pContenido,
                EstadoEnviado = DateTime.Today.ToShortDateString()
            };

            return AgregarDestinatarios(iMensajeCompletoDTO, pDestinatario);
        }

    }
}