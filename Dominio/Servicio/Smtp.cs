using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;

namespace Dominio.Servicio
{
    public class Smtp : Protocolo, IProtocoloTransmision
    {
        public void Enviar(IMensaje pMensaje, string pDireccion, string pContraseña)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));
            if (string.IsNullOrEmpty(pDireccion))
                throw new ArgumentNullException(nameof(pDireccion));
            if (string.IsNullOrEmpty(pContraseña))
                throw new ArgumentNullException(nameof(pContraseña));

            try
            {
                SmtpClient iClienteSmtp = new SmtpClient(this.Host, this.Puerto);
                iClienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                iClienteSmtp.EnableSsl = this.SSL;
                iClienteSmtp.UseDefaultCredentials = false;
                iClienteSmtp.Credentials = new NetworkCredential(pDireccion,pContraseña);


                MailMessage mensaje = new MailMessage()
                {
                    From = new MailAddress(pDireccion),
                    Subject = pMensaje.Asunto,
                    Body = pMensaje.Contenido,
                };
                pMensaje.Destinatario.ToList().ForEach(x => mensaje.To.Add(x.DireccionCorreo.DireccionDeCorreo));

                iClienteSmtp.Send(mensaje);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new SmtpException("El puerto no puede ser un numero menor a cero", ex);
            }
            catch(ArgumentException ex)
            {
                throw new SmtpException("Algún campo del mensaje es nulo o vacío", ex);
            }
        }
    }
}
