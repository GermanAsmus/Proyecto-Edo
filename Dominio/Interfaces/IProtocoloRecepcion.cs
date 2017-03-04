using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading;

namespace Dominio
{
    /// <summary>
    /// Protocolo de recepción de correos.
    /// </summary>
    public interface IProtocoloRecepcion
    {
        int CantidadDescargas { get; set; }

        /// <summary>
        /// Descarga una colección de mensajes del servidor
        /// </summary>
        IEnumerable<IMensaje> Descargar(string pDireccion, string pContraseña);
        /// <summary>
        /// Descarga un mensaje particular del servidor.
        /// </summary>
        IMensaje Descargar(int pIdMensaje, string pDireccion, string pContraseña);
        /// <summary>
        /// Elimina una cantidad de mensajes del servidor.
        /// </summary>
        /// <param name="pIdMensaje">Identificador del mensaje en el servidor</param>
        void Eliminar(int pIdMensaje, string pDireccion, string pContraseña);
    }
}
