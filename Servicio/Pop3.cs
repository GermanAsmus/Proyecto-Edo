using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using OpenPop.Pop3;
using System.Threading.Tasks;
using Modelo;

namespace Servicio
{

    public class Pop3
    {
        private Cuenta iCuenta;
        private Buzon iBuzon;

        public Pop3(Cuenta cuentaUsuario, Buzon buzon)
        {
            iCuenta = cuentaUsuario;
            iBuzon = buzon;
        }
        /// <summary>
        /// Se descarga una cabecera particular respectiva al id <paramref name="i"/>
        /// </summary>
        /// <param name="i">identificador del mensaje</param>
        private void doGetMessageHeader(int i)
        {

            var client = new Pop3Client();
            //Conexion y Autorizacion del servidor
            client.Connect(iCuenta.Servidor.HostPOP, iCuenta.Servidor.PuertoPOP, iCuenta.Servidor.SSL);
            client.Authenticate(iCuenta.DireccionId, iCuenta.Contraseña);
            client.Reset();

            if (i > client.GetMessageCount())
                throw new TaskCanceledException("fuera del indice");

            var t = client.GetMessageHeaders(i + 1);
            //Desconexion del servidor
            client.Disconnect();


            // Se convierte MessageHeader (entidad del paquete OpenPop.Net), 
            // a Cabecera (entidad propia del modelo)

            Mensaje cabecera = new Cabecera()
            {
                Fecha = t.Date,
                Asunto = t.Subject,
                DireccionCorreo = new DireccionCorreo() { DireccionId = t.From.Address },
                MensajeId = t.MessageId
            };
            t.To.ForEach(x => cabecera.Destinatario.Add(new DireccionCorreo() { DireccionId = x.Address }));

            // Se agrega la cabecera al buzon
            iBuzon.agregarCabecera(cabecera);
        }
        /// <summary>
        /// Se descarga la n <paramref name="cantiad"/> de cabeceras de la cuenta asociada.
        /// </summary>
        /// <param name="cantidad">cantidad de cabeceras a descargar</param>
        public void DescargarCabeceras(int cantidad)
        {
            try
            {
                Parallel.For(0, cantidad, new ParallelOptions() { MaxDegreeOfParallelism = 1 }, i => doGetMessageHeader(i));
            }
            catch (Exception)
            {
                //
            }
        }
        /// <summary>
        /// Se descarga un mensaje particular respectivo al id <paramref name="i"/>.
        /// </summary>
        /// <param name="i">identificador del mensaje</param>
        private void doGetMessage(int i)
        {
            var client = new Pop3Client();
            //Conexion y Autorizacion del servidor
            client.Connect(iCuenta.Servidor.HostPOP, iCuenta.Servidor.PuertoPOP, iCuenta.Servidor.SSL);
            client.Authenticate(iCuenta.DireccionId, iCuenta.Contraseña);
            client.Reset();

            if (i > client.GetMessageCount())
                throw new TaskCanceledException("fuera del indice");

            var t = client.GetMessage(i + 1);

            //Desconexion del servidor
            client.Disconnect();
            Mensaje mensaje = new Completo()
            {
                Fecha = t.Headers.Date,
                Asunto = t.Headers.Subject,
                DireccionCorreo = new DireccionCorreo() { DireccionId = t.Headers.From.Address },
                MensajeId = t.Headers.MessageId,
                Contenido = t.MessagePart.GetBodyAsText()
            };
            t.Headers.To.ForEach(x => mensaje.Destinatario.Add(new DireccionCorreo() { DireccionId = x.Address }));
            List<InfoAdjunto> listaAdjuntos = new List<InfoAdjunto>();
            t.FindAllAttachments().ForEach(x => listaAdjuntos.Add(new InfoAdjunto() { Nombre = x.FileName, Contenido = x.Body }));
            Descargar.DescargarAdjunto(listaAdjuntos).ForEach(x => ((Completo)mensaje).Adjuntos.Add(new Adjunto() { AdjuntoId = x}));

            //Se agrega el mensaje al buzon
            iBuzon.agregarMensaje(mensaje);
        }
        /// <summary>
        /// Se descarga la n <paramref name="cantiad"/> de mensajes de la cuenta asociada.
        /// </summary>
        /// <param name="pCantidad">cantidad de mensajes a descargar</param>
        public void DescargarMensaje(int pCantidad)
        {
            try
            {
                Parallel.For(0, pCantidad, new ParallelOptions() { MaxDegreeOfParallelism = 2 }, i => doGetMessage(i));
            }
            catch (Exception)
            {
                //
            }
        }

        /// <summary>
        /// Se elimina un mensaje repectivo al <paramref name="id"/> asociado.
        /// </summary>
        /// <param name="id"></param>
        public void EliminarMensaje(int id)
        {
            try
            {
                var client = new Pop3Client();
                //Conexion y Autorizacion del servidor
                client.Connect(iCuenta.Servidor.HostPOP, iCuenta.Servidor.PuertoPOP, iCuenta.Servidor.SSL);
                client.Authenticate(iCuenta.DireccionId, iCuenta.Contraseña);
                client.Reset();
                //Eliminacion del mensaje en el servidor
                client.DeleteMessage(id);
                //Desconexion del servidor
                client.Disconnect();
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
