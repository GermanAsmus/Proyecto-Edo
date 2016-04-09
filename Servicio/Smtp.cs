using Modelo;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace Servicio
{
    public class Smtp
    {
        private SmtpClient iSmtp;

        public Smtp(Cuenta cuenta)
        {
            iSmtp = new SmtpClient(cuenta.Servidor.HostSMTP, cuenta.Servidor.PuertoSMTP);
            iSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            iSmtp.EnableSsl = cuenta.Servidor.SSL;
            iSmtp.UseDefaultCredentials = false;
            iSmtp.Credentials = new NetworkCredential(cuenta.DireccionId, cuenta.Contraseña);

        }
        public void Enviar(Completo pMensaje)
        {
            if (this.iSmtp == null)
                throw new ApplicationException("El cliente SMTP no está inicializado");

            MailMessage mensaje = new MailMessage()
            {
                From = new MailAddress(pMensaje.Remitente),
                Subject = pMensaje.Asunto,
                Body = pMensaje.Contenido,
            };
            pMensaje.Adjuntos.ToList().ForEach(x => mensaje.Attachments.Add(new Attachment(x.AdjuntoId)));
            pMensaje.Destinatario.ToList().ForEach(x => mensaje.To.Add(x.DireccionId));

            iSmtp.Send(mensaje);
        }
    }
}
