using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using Servicio.Excepciones;

namespace Servicio
{
    public class ProtocoloSmtp : ProtocoloAbstract
    {

        public ProtocoloSmtp(string pDireccion, string pContraseña, string pHost, int? pPuerto, bool pSSL) : base(pDireccion, pContraseña, pHost, pPuerto, pSSL)
        {
        }

        public void Enviar(MailMessage pMensaje)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));
            SmtpClient iClienteSmtp = new SmtpClient();
            try
            {
                iClienteSmtp.Host = this.iHost;
                iClienteSmtp.Port = this.iPuerto;
                iClienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                iClienteSmtp.EnableSsl = this.iSSL;
                iClienteSmtp.UseDefaultCredentials = false;
                iClienteSmtp.Credentials = new NetworkCredential(this.iDireccion, this.iContraseña);
                iClienteSmtp.Send(pMensaje);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new SmtpClientException("El puerto no puede ser un numero menor a cero", ex);
            }
            catch(ArgumentException ex)
            {
                throw new SmtpClientException("Algún campo del mensaje es nulo o vacío", ex);
            }
            finally
            {
                iClienteSmtp.Dispose();
            }
        }
    }
}
