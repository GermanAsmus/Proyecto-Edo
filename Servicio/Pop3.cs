using System;
using System.Collections.Generic;
using OpenPop.Pop3;
using OpenPop.Pop3.Exceptions;
using System.Threading.Tasks;
using Modelo;
using OpenPop.Mime.Header;
using OpenPop.Mime;
using Servicio.Excepciones;
using CapaInterfaces.Servicio;
using CapaInterfaces.Utilidades;
using Utilidades.Misc;
using System.Threading;

namespace Servicio
{

    public class Pop3 : IProtocoloRecepcion
    {
        public Action ActualizacionBuzon;

        public Cuenta CuentaUsuario { get; set; }
        public IBuzon Buzon { get; set; }

        public Pop3()
        {
            ((Buzon)Buzon).BagChanged += Actualizacion;
        }

        private void Actualizacion()
        {
            ActualizacionBuzon();
        }

        private void ObtenerCabecera(int pId, Pop3Client pCliente)
        {
            try
            {
                MessageHeader iCabecera = pCliente.GetMessageHeaders(pId + 1);
                this.ToMensaje(iCabecera);
            }
            catch (PopServerException ex)
            {
                throw new GetMessageFromServerException("No se pudo obtener el mensaje del servidor. Verifique la conexion a internet.", ex);
            }
        }
        private void ObtenerMensaje(int pId, Pop3Client pCliente)
        {
            try
            {
                var iMensaje = pCliente.GetMessage(pId + 1);
                this.ToMensaje(iMensaje);
            }
            catch (PopServerException ex)
            {
                throw new GetMessageFromServerException("No se pudo obtener el mensaje del servidor. Verifique la conexion a internet.", ex);
            }
        }

        private void ToMensaje(MessageHeader pMensaje)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            Mensaje iMensajeCabecera = new Mensaje()
            {
                Fecha = pMensaje.Date,
                Asunto = pMensaje.Subject,
                DireccionCorreo = new DireccionCorreo() { DireccionDeCorreo = pMensaje.From.Address },
                CodigoMensaje = pMensaje.MessageId
            };
            pMensaje.To.ForEach(x => iMensajeCabecera.Destinatario.Add(new DireccionCorreo() { DireccionDeCorreo = x.Address }));
            Buzon.AgregarCabecera(iMensajeCabecera);
        }
        private void ToMensaje(Message pMensaje)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            Mensaje mensaje = new Mensaje()
            {
                Fecha = pMensaje.Headers.Date,
                Asunto = pMensaje.Headers.Subject,
                DireccionCorreo = new DireccionCorreo() { DireccionDeCorreo = pMensaje.Headers.From.Address },
                CodigoMensaje = pMensaje.Headers.MessageId,
            };

            if (pMensaje.MessagePart.Body != null)
                mensaje.Contenido = pMensaje.MessagePart.GetBodyAsText();
            else
                mensaje.Contenido = string.Empty;


            pMensaje.Headers.To.ForEach(x => mensaje.Destinatario.Add(new DireccionCorreo() { DireccionDeCorreo = x.Address }));
            List<InfoAdjunto> listaAdjuntos = new List<InfoAdjunto>();
            pMensaje.FindAllAttachments().ForEach(x => listaAdjuntos.Add(new InfoAdjunto() { Nombre = x.FileName, Contenido = x.Body }));

            Utilidades.SistemaDeArchivos.Descargar.DescargarAdjunto(listaAdjuntos).ForEach(x => mensaje.Adjuntos.Add(new Adjunto() { CodigoAdjunto = x }));

            Buzon.AgregarMensaje(mensaje);
        }

        public void Descargar(CancellationToken pCanelation)
        {
            IList<Task> iTasks = new List<Task>();
            int iCantidad = 0;
            using (Pop3Client iCliente = ObtenerCliente())
            {
                iCantidad = iCliente.GetMessageCount();
                int i = 0;
                while (!pCanelation.IsCancellationRequested && i<iCantidad)
                {
                    iTasks.Add(Task.Factory.StartNew(() =>
                    {
                        this.ObtenerCabecera(i,iCliente);
                    }));
                    i++;
                }
                if (pCanelation.IsCancellationRequested)
                    iCliente.Disconnect();
            }
        }
        public void Descargar(int pIdMensaje,CancellationToken pCanelation)
        {
            Task iDescargarMensaje;
            using (Pop3Client iCliente = ObtenerCliente())
            {
                if (!pCanelation.IsCancellationRequested)
                    iDescargarMensaje = (Task.Factory.StartNew(() =>
                    {
                        this.ObtenerMensaje(pIdMensaje, iCliente);
                    }));
                else
                    iCliente.Disconnect();
            }
        }

        //public void Descargar(int pCantidad)
        //{
        //    try
        //    {
        //        IList<Task> iTasks = new List<Task>();
        //        for (int i = 0; i < pCantidad; i++)
        //        {
        //            iTasks.Add(Task.Factory.StartNew(() =>
        //            {
        //                using (Pop3Client iCliente = ObtenerCliente())
        //                {
        //                    int iCantidadReal = iCliente.GetMessageCount();
        //                    if (i > iCantidadReal)
        //                        i = iCantidadReal;
        //                    this.ObtenerCabecera(i, iCliente);
        //                }

        //            }));
        //            iTasks.Add(Task.Factory.StartNew(() =>
        //            {
        //                using (Pop3Client iCliente = ObtenerCliente())
        //                {
        //                    int iCantidadReal = iCliente.GetMessageCount();
        //                    if (i > iCantidadReal)
        //                        i = iCantidadReal;
        //                    this.ObtenerMensaje(i, iCliente);
        //                }
        //            }));
        //        }
        //        Task.WaitAll(iTasks.ToArray());
        //    }
        //    catch (Pop3ClientException ex)
        //    {
        //        throw new Pop3ClientException("No se pudo obtener el cliente pop3.", ex);
        //    }
        //}
        public Pop3Client ObtenerCliente()
        {
            try
            {
                Pop3Client iCliente = new Pop3Client();

                Modelo.Protocolo iPop = CuentaUsuario.Servidor.ObtenerProtocolo("pop3");

                iCliente.Connect(iPop.Host, iPop.Puerto, iPop.SSL);
                iCliente.Authenticate(CuentaUsuario.DireccionCorreo.DireccionDeCorreo, CuentaUsuario.Contraseña);
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
                    //Desconexion del servidor
                    iCliente.Disconnect();
                }
            }
            catch (PopClientException ex)
            {
                throw new Pop3ClientException("No se pudo eliminar el mensaje, problemas con el cliente pop3. Ver excepcion interna.", ex);
            }
        }
    }
}
