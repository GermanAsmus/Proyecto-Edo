using Modelo;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using ControlDependencia;

namespace Servicio
{
    public sealed class Smtp : IProtocoloTransmision
    {
        public void Enviar(Mensaje pMensaje, Cuenta pCuenta)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

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
    }
}
