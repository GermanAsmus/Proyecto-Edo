using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using OpenPop.Pop3;
using System.Threading.Tasks;
using Modelo;
using ControlDependencia;
using Utilidades;
using OpenPop.Mime.Header;
using OpenPop.Mime;

namespace Servicio
{

    public class Pop3 : IProtocoloRecepcion
    {
        public Action MensajeDescargado;
        public Cuenta CuentaUsuario { get; }

        public IBuzon Buzon { get; }

        public Pop3(Cuenta pCuentaUsuario, Buzon pBuzon)
        {
            CuentaUsuario = pCuentaUsuario;
            pBuzon.BagChanged += Descarga;
            Buzon = pBuzon;
        }
        private void Descarga()
        {
            MensajeDescargado();
        }

        private void ObtenerCabecera(int pId, Pop3Client pCliente)
        {
            MessageHeader iCabecera = pCliente.GetMessageHeaders(pId + 1);
            this.ToMensaje(iCabecera);
        }
        private void ObtenerMensaje(int pId, Pop3Client pCliente)
        {
            var iMensaje = pCliente.GetMessage(pId + 1);
            this.ToMensaje(iMensaje);
        }

        private void ToMensaje(MessageHeader pMensaje)
        {
            Mensaje iMensajeCabecera = iMensajeCabecera = new Mensaje()
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
                throw new Exception();

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

            Utilidades.Descargar.DescargarAdjunto(listaAdjuntos).ForEach(x => mensaje.Adjuntos.Add(new Adjunto() { CodigoAdjunto = x }));

            Buzon.AgregarMensaje(mensaje);
        }

        public void Descargar(int pCantidad)
        {
            IList<Task> iTasks = new List<Task>();
            for (int i = 0; i < pCantidad; i++)
            {
                iTasks.Add(Task.Factory.StartNew(() =>
                {
                    using (Pop3Client iCliente = ObtenerCliente())
                    {
                        int iCantidadReal = iCliente.GetMessageCount();
                        if (i > iCantidadReal)
                            i = iCantidadReal;
                        this.ObtenerCabecera(i, iCliente);
                    }

                }));
                iTasks.Add(Task.Factory.StartNew(() =>
                {
                    using (Pop3Client iCliente = ObtenerCliente())
                    {
                        int iCantidadReal = iCliente.GetMessageCount();
                        if (i > iCantidadReal)
                            i = iCantidadReal;
                        this.ObtenerMensaje(i, iCliente);
                    }
                }));
            }
            Task.WaitAll(iTasks.ToArray());
        }
        public Pop3Client ObtenerCliente()
        {
            Pop3Client iCliente = new Pop3Client();

            iCliente.Connect(CuentaUsuario.Servidor.HostPOP, CuentaUsuario.Servidor.PuertoPOP, CuentaUsuario.Servidor.SSL);
            iCliente.Authenticate(CuentaUsuario.DireccionCorreo.DireccionDeCorreo, CuentaUsuario.Contraseña);
            iCliente.Reset();

            return iCliente;
        }

        public void Eliminar(int pId)
        {
            using (Pop3Client iCliente = new Pop3Client())
            {
                //Conexion y Autorizacion del servidor
                iCliente.Connect(CuentaUsuario.Servidor.HostPOP, CuentaUsuario.Servidor.PuertoPOP, CuentaUsuario.Servidor.SSL);
                iCliente.Authenticate(CuentaUsuario.DireccionCorreo.DireccionDeCorreo, CuentaUsuario.Contraseña);
                iCliente.Reset();
                //Eliminacion del mensaje en el servidor
                iCliente.DeleteMessage(pId);
                //Desconexion del servidor
                iCliente.Disconnect();
            }
        }
    }
}
