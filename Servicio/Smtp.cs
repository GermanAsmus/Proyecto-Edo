using Modelo;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using ControlDependencia;
using Servicio.Excepciones;
using ControlDependencia.Servicio;

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
                Modelo.Protocolo iSmtp = pCuenta.Servidor.ObtenerProtocolo("smtp");

                SmtpClient iClienteSmtp = new SmtpClient(iSmtp.Host, iSmtp.Puerto);
                iClienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                iClienteSmtp.EnableSsl = iSmtp.SSL;
                iClienteSmtp.UseDefaultCredentials = false;
                iClienteSmtp.Credentials = new NetworkCredential(pCuenta.DireccionCorreo.DireccionDeCorreo, pCuenta.Contraseña);


                MailMessage mensaje = new MailMessage()
                {
                    From = new MailAddress(pMensaje.DireccionCorreo.DireccionDeCorreo),
                    Subject = pMensaje.Asunto,
                    Body = pMensaje.Contenido,
                };
                pMensaje.Adjuntos.ToList().ForEach(x => mensaje.Attachments.Add(new Attachment(x.CodigoAdjunto)));
                pMensaje.Destinatario.ToList().ForEach(x => mensaje.To.Add(x.DireccionDeCorreo));

                iClienteSmtp.Send(mensaje);
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
