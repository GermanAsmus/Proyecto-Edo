using Modelo;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using ControlDependencia;
using Servicio.Excepciones;

namespace Servicio
{
    public sealed class Smtp : IProtocoloTransmision
    {
        public void Enviar(Mensaje pMensaje, Cuenta pCuenta)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            try
            {
                SmtpClient iSmtp = new SmtpClient(pCuenta.Servidor.HostSMTP, pCuenta.Servidor.PuertoSMTP);
                iSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                iSmtp.EnableSsl = pCuenta.Servidor.SSL;
                iSmtp.UseDefaultCredentials = false;
                iSmtp.Credentials = new NetworkCredential(pCuenta.DireccionCorreo.DireccionDeCorreo, pCuenta.Contraseña);


                MailMessage mensaje = new MailMessage()
                {
                    From = new MailAddress(pMensaje.DireccionCorreo.DireccionDeCorreo),
                    Subject = pMensaje.Asunto,
                    Body = pMensaje.Contenido,
                };
                pMensaje.Adjuntos.ToList().ForEach(x => mensaje.Attachments.Add(new Attachment(x.CodigoAdjunto)));
                pMensaje.Destinatario.ToList().ForEach(x => mensaje.To.Add(x.DireccionDeCorreo));

                iSmtp.Send(mensaje);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new SmtpClientException("El puerto no puede ser un numero menor a cero", ex);
            }
            catch(ArgumentException ex)
            {
                throw new SmtpClientException("Algún campo del mensaje es nulo o vacío", ex);
            }
        }
    }
}
