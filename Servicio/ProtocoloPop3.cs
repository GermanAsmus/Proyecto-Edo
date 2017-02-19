using System;
using System.Collections.Generic;
using OpenPop.Pop3;
using OpenPop.Pop3.Exceptions;
using System.Threading.Tasks;
using OpenPop.Mime.Header;
using OpenPop.Mime;
using Servicio.Excepciones;
using System.Threading;
using System.Net.Mail;
using System.Linq;

namespace Servicio
{

    public class ProtocoloPop3 : ProtocoloAbstract
    {
        public ProtocoloPop3(string pDireccion, string pContraseña, string pHost, int? pPuerto, bool pSSL) : base(pDireccion, pContraseña, pHost, pPuerto, pSSL)
        {
        }
        private MailMessage ParseMessageFromHeader(MessageHeader pHeader)
        {
            if (pHeader == null)
                throw new ArgumentNullException(nameof(pHeader));

            MailMessage aResultMessageHeader = new MailMessage()
            {
                From = pHeader.From.MailAddress,
                Subject = pHeader.Subject                
            };

            foreach (RfcMailAddress aDestinatario in pHeader.To)
            {
                aResultMessageHeader.To.Add(aDestinatario.MailAddress);
            }

            return aResultMessageHeader;
        }
        /// <summary>
        /// Obtiene unicamente la cabezera del mensaje.
        /// </summary>
        private MailMessage ObtenerCabecera(int pId, Pop3Client pCliente)
        {
            try
            {
                 
                MessageHeader header = pCliente.GetMessageHeaders(pId + 1);
                return this.ParseMessageFromHeader(header);
            }
            catch (PopServerException ex)
            {
                throw new GetMessageFromServerException("No se pudo obtener el mensaje del servidor. Verifique la conexion a internet.", ex);
            }
        }
        /// <summary>
        /// Obtiene el mensaje completo
        /// </summary>
        private MailMessage ObtenerMensaje(int pId, Pop3Client pCliente)
        {
            try
            {
                return pCliente.GetMessage(pId + 1).ToMailMessage();
            }
            catch (PopServerException ex)
            {
                throw new GetMessageFromServerException("No se pudo obtener el mensaje del servidor. Verifique la conexion a internet.", ex);
            }
        }

        /// <summary>
        /// Descarga las cabeceras de todos los mensajes
        /// </summary>
        public IEnumerable<MailMessage> DescargarCabeceras(int pCantidad = 0)
        {
            using (Pop3Client aCliente = this.ObtenerCliente())
            {
                IList<MailMessage> aCabeceras = new List<MailMessage>();
                int aCantidad = pCantidad == 0 ? aCliente.GetMessageCount() : pCantidad;
                for (int i = 0; i < aCantidad; i++)
                {
                    aCabeceras.Add(this.ObtenerCabecera(i, aCliente));
                }
                return aCabeceras;
            }
        }
        /// <summary>
        /// Descarga un mensaje particular, indicado por su id.
        /// </summary>
        public MailMessage Descargar(int pIdMensaje)
        {
            using (Pop3Client iCliente = ObtenerCliente())
            {
                return this.ObtenerMensaje(pIdMensaje, iCliente);
            }
        }

        protected Pop3Client ObtenerCliente()
        {
            try
            {
                Pop3Client iCliente = new Pop3Client();

                iCliente.Connect(this.iHost, this.iPuerto, this.iSSL);
                iCliente.Authenticate(this.iDireccion, this.iContraseña);
                iCliente.Reset();

                return iCliente;
            }
            catch (PopClientException ex)
            {
                throw new Pop3ClientException("No se pudo completar con la conexión ni la autenticación, problemas con el cliente pop3. Ver excepcion interna.", ex);
            }
        }

        public void Eliminar(int pId)
        {
            try
            {
                using (Pop3Client iCliente = ObtenerCliente())
                {
                    iCliente.DeleteMessage(pId);
                }
            }
            catch (PopClientException ex)
            {
                throw new Pop3ClientException("No se pudo eliminar el mensaje, problemas con el cliente pop3. Ver excepcion interna.", ex);
            }
        }
    }
}
