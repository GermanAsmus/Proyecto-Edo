using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    /// <summary>
    /// Permite la concurrencia de la descarga de los mensajes.
    /// </summary>
    public interface IConcurrentMailMessageBucket
    {
        /// <summary>
        /// Mantiene las cabeceras de los mensajes.
        /// </summary>
        IEnumerable<MailMessage> MessageHeader { get;}
        /// <summary>
        /// Mantiene los mensajes completos.
        /// </summary>
        IEnumerable<MailMessage> FullMessages { get;}

        /// <summary>
        /// Agrega un mensaje a la colección
        /// </summary>
        /// <param name="pFullMessage"></param>
        /// <returns>True si pudo agregar el elemento</returns>
        bool AddFullMessage(MailMessage pFullMessage);
        /// <summary>
        /// Agrega una cabecera a la colección
        /// </summary>
        /// <param name="pHeaderMessage"></param>
        /// <returns>True si pudo agregar el elemento</returns>
        bool AddHeaderMessage(MailMessage pHeaderMessage);
    }
}
