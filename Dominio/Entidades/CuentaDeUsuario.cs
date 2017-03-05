using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dominio.Helper;
using System.Linq;
using System.Net.Mail;

namespace Dominio
{
    public class CuentaDeUsuario : ICuentaDeUsuario
    {

        #region propiedades
        public byte Id { get; set; }

        public byte DireccionId { get; set; }

        public IDireccionCorreo DireccionDeCorreo { get; set; }

        public IServidor Servidor { get; set; }

        public string Contraseña { get; set; }

        public string Nombre { get; set; } 
        #endregion

        /// <summary>
        /// Constructor de la clase, toma un string como direccion de correo.
        /// </summary>
        /// <param name="pDireccion"></param>
        public CuentaDeUsuario(string pDireccion)
        {
            if (string.IsNullOrEmpty(pDireccion))
                throw new ArgumentNullException(nameof(pDireccion));

                this.DireccionDeCorreo = new DireccionCorreo(pDireccion);
                string host = DireccionCorreo.ObtenerHost(this.DireccionDeCorreo);
                this.Servidor = CreadorServidor.CrearServidor(host);

        }
        /// <summary>
        /// Constructor de la clase, toma una direccion de correo existente.
        /// </summary>
        public CuentaDeUsuario(IDireccionCorreo pDireccion)
        {
            if (this.DireccionDeCorreo == null)
                throw new ArgumentNullException(nameof(pDireccion));

            this.DireccionDeCorreo = pDireccion;
                string host = DireccionCorreo.ObtenerHost(this.DireccionDeCorreo);
            this.Servidor = CreadorServidor.CrearServidor(host);
        }

        public IMensajeDTO ObtenerUnMensaje(int pIdMensaje, bool pRemoto = false)
        {
            if (pIdMensaje < 1)
                throw new ApplicationException();

            if (pRemoto)
                return this.DescargarMensajeRemoto(pIdMensaje);
            else
                return this.DireccionDeCorreo.MensajesRemitente.First(m => m.Id == pIdMensaje);
            
        }
        private IMensajeDTO DescargarMensajeRemoto(int pIdMensaje)
        {
            IProtocoloRecepcion aProtocoloPop = (Pop3)this.Servidor.ObtenerProtocoloRecepcion();
            return aProtocoloPop.Descargar(pIdMensaje, this.DireccionDeCorreo.DireccionDeCorreo, this.Contraseña);
        }

        public IEnumerable<IMensajeDTO> ObtenerMenasjes(int pCantidad = 0, bool pRemoto = false)
        {
            if (pRemoto)
                return this.DescargarMensajesRemotos(pCantidad);
            else
                return this.DireccionDeCorreo.MensajesRemitente;
        }
        private IEnumerable<IMensajeDTO> DescargarMensajesRemotos(int pCantidad)
        {
            IProtocoloRecepcion aProtocoloRecepcion = this.Servidor.ObtenerProtocoloRecepcion() as Pop3;
            aProtocoloRecepcion.CantidadDescargas = pCantidad;
            return aProtocoloRecepcion.Descargar(this.DireccionDeCorreo.DireccionDeCorreo, this.Contraseña);
        }

        public void EliminarMensaje(int pIdMensaje)
        {
            //se elimina de la bbdd
            IMensajeDTO aMensaje = this.DireccionDeCorreo.MensajesRemitente.First(m => m.Id == pIdMensaje);
            //puede ocurrir que el mensaje no esté en la bbdd
            if (aMensaje!=null)
                this.DireccionDeCorreo.MensajesRemitente.Remove(aMensaje);

            //se elimina del servidor
            Pop3 aProtocolo = (Pop3)this.Servidor.ObtenerProtocoloRecepcion();
            aProtocolo.Eliminar(pIdMensaje, this.DireccionDeCorreo.DireccionDeCorreo, this.Contraseña);
        }

        public void EnviarMensaje(string pAsunto, ICollection<IDireccionCorreo> pDestinatario, string pContenido = "")
        {
            IMensajeDTO aMensaje = CreadorMensajes.CrearMensaje(this.DireccionDeCorreo, pAsunto, pDestinatario, pContenido);
            this.DireccionDeCorreo.MensajesRemitente.Add(aMensaje);
            this.EnviarMensaje(aMensaje);
        }
        private void EnviarMensaje(IMensajeDTO pMensaje)
        {
            (this.Servidor.ObtenerProtocoloTransmision() as IProtocoloTransmision).Enviar(pMensaje, this.DireccionDeCorreo.DireccionDeCorreo, this.Contraseña);
        }
    }
}