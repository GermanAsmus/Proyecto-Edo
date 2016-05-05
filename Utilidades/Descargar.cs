using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;
using Modelo;
using System.Net.Mail;
using Utilidades.Excepciones;

namespace Utilidades
{
    public class Descargar
    {
        private static string DireccionRaiz = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments);

        private static string DescargarArchivo(MemoryStream stream, string pathString)
        {
            if (string.IsNullOrWhiteSpace(pathString))
                throw new ArgumentNullException(nameof(pathString));

            if (stream == Stream.Null)
                throw new ArgumentNullException(nameof(stream));

            string fileName = string.Empty;

            if (!File.Exists(pathString))
            {
                File.WriteAllBytes(pathString, stream.ToArray());
                fileName = pathString;
            }

            return fileName;
        }
        private static string DescargarArchivo(string textoPlano, string pathString)
        {
            if (string.IsNullOrWhiteSpace(pathString))
                throw new ArgumentNullException(nameof(pathString));

            if (string.IsNullOrWhiteSpace(textoPlano))
                throw new ArgumentNullException(nameof(textoPlano));

            string fileName = string.Empty;

            if (!File.Exists(pathString))
            {
                File.WriteAllText(pathString, textoPlano, Encoding.UTF8);
                fileName = pathString;
            }

            return fileName;
        }
        private static string CrearDirectorio(string pDirectorio)
        {
            if (string.IsNullOrWhiteSpace(pDirectorio))
                throw new ArgumentNullException(nameof(pDirectorio));

            string pathString = Path.Combine(DireccionRaiz, "Edo", pDirectorio);

            if (Directory.Exists(pathString))
                throw new ApplicationException("El Direcrorio ya existe");
            try
            {
                DirectoryInfo info = Directory.CreateDirectory(pathString);
                return info.Name;
            }
            catch (IOException ex)
            {
                throw new CreateDirectoryException("No se pudo crear del directorio", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new CreateDirectoryException("La creacion del directorio fue cancelada por falta de permisos", ex);
            }
            catch (NotSupportedException ex)
            {
                throw new CreateDirectoryException("No se pudo crear del directorio, funcionalidades no soportadas",ex);
            }
        }
        public static List<string> DescargarAdjunto(List<InfoAdjunto> pAdjuntos)
        {
            //solo si existen adjuntos
            if (pAdjuntos.Count==0)
                return new List<string>() { };

                string pathString = string.Empty;
                IProducerConsumerCollection<string> nombres = new ConcurrentBag<string>();

                try
                {
                    pathString = CrearDirectorio("Adjuntos");

                }
                catch (ApplicationException)
                {
                    pathString = Path.Combine(DireccionRaiz, "Edo", "Adjuntos");
                }
                finally
                {
                    string pathAux = pathString;
                    foreach (InfoAdjunto attachmentMessagePart in pAdjuntos)
                    {
                        pathAux = Path.Combine(pathString, attachmentMessagePart.Nombre);
                        nombres.TryAdd(DescargarArchivo(new MemoryStream(attachmentMessagePart.Contenido), pathAux));
                    }

                }
                //devolver todos los nombres que no sean string.Empty
                return nombres.SkipWhile(x => !string.IsNullOrEmpty(x)).ToList();
        }
        public static string DescargarTextoPlano(Mensaje pMensaje)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            string destinatario = string.Empty;

            pMensaje.Destinatario.ToList().ForEach(x => destinatario += string.Format("> {0}{1}", x.DireccionDeCorreo, Environment.NewLine));

            object[] param =
           {
                Environment.NewLine,
                pMensaje.DireccionCorreo.DireccionDeCorreo,
                pMensaje.Fecha,
                destinatario,
                pMensaje.Asunto,
                pMensaje.Contenido
            };
            string textoPlano = string.Format(@"Remitente: {1},{0}Fecha: {2},{0}Destinatario:{0}{3},{0}Asunto: {4},{0}Cuerpo: {5}", param);

            return DescargarArchivo(textoPlano, Path.Combine(DireccionRaiz, "Edo", param[4].ToString() + ".txt"));
        }
        public static string DescargarMensaje(Mensaje pMensaje)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            MailMessage message = new MailMessage()
            {
                From = new MailAddress(pMensaje.DireccionCorreo.DireccionDeCorreo),
                Subject = pMensaje.Asunto,
                Body = pMensaje.Contenido
            };
            foreach (var item in pMensaje.Destinatario)
            {
                message.To.Add(item.DireccionDeCorreo);
            }
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                client.PickupDirectoryLocation = Path.Combine(DireccionRaiz, "Edo");
                client.Send(message);

                return Path.Combine(DireccionRaiz, "Edo");
            }
            catch (SmtpException ex)
            {
                throw new ApplicationException("Problemas guardando el mensaje.", ex);
            }
        }
    }
}
