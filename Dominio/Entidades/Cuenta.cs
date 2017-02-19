using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dominio.Entidades.Interfaces;
using Dominio.Entidades.Helper;
using System.Linq;
using Dominio.Servicio;
using System.Net.Mail;

namespace Dominio.Entidades
{
    public class Cuenta : ICuenta
    {

        #region propiedades
        public int Id { get; set; }

        public int DireccionId { get; set; }

        public IDireccionCorreo DireccionCorreo { get; set; }

        public virtual ICollection<IMensaje> Mensajes { get; set; }

        public IServidor Servidor { get; set; }

        public string Contraseña { get; set; }

        public string Nombre { get; set; } 
        #endregion

        /// <summary>
        /// Constructor de la clase, toma un string como direccion de correo.
        /// </summary>
        /// <param name="pDireccion"></param>
        public Cuenta(string pDireccion = null)
        {
            this.Mensajes = new List<IMensaje>();
            if (!string.IsNullOrEmpty(pDireccion))
            {
                this.NuevaDireccionDeCorreo(pDireccion);
                string host = Entidades.DireccionCorreo.ObtenerHost(this.DireccionCorreo);
                this.Servidor = CreadorServidor.CrearServidor(host);
            }
        }
        /// <summary>
        /// Constructor de la clase, toma una direccion de correo existente.
        /// </summary>
        public Cuenta(IDireccionCorreo pDireccion = null)
        {
            this.DireccionCorreo = pDireccion;
            this.Mensajes = new List<IMensaje>();
            if (this.DireccionCorreo != null)
            {
                string host = Entidades.DireccionCorreo.ObtenerHost(this.DireccionCorreo);
                this.Servidor = CreadorServidor.CrearServidor(host);
            }
        }
        /// <summary>
        /// Agrega una nueva direccion de correo a la cuenta.
        /// </summary>
        public void NuevaDireccionDeCorreo(string pDireccion)
        {
            this.DireccionCorreo = new DireccionCorreo(pDireccion);
        }

        public IMensaje DescargarMensaje(int pIdMensaje)
        {
            IProtocoloRecepcion aProtocoloPop = (Pop3)this.Servidor.ObtenerProtocoloRecepcion();
            return aProtocoloPop.Descargar(pIdMensaje, this.DireccionCorreo.DireccionDeCorreo, this.Contraseña);
        }
        public IEnumerable<IMensaje> Descargar(int pCantidad = 0)
        {
            IProtocoloRecepcion aProtocoloRecepcion = this.Servidor.ObtenerProtocoloRecepcion() as Pop3;
            aProtocoloRecepcion.CantidadDescargas = pCantidad;
            return aProtocoloRecepcion.Descargar(this.DireccionCorreo.DireccionDeCorreo, this.Contraseña);
        }

        public void EnviarMensaje(IMensaje pMensaje)
        {
            (this.Servidor.ObtenerProtocoloTransmision()as IProtocoloTransmision).Enviar(pMensaje, this.DireccionCorreo.DireccionDeCorreo, this.Contraseña);
        }

        public void EliminarMensaje(int pIdMensaje)
        {
            (this.Servidor.ObtenerProtocoloRecepcion()as IProtocoloRecepcion).Eliminar(pIdMensaje, this.DireccionCorreo.DireccionDeCorreo, this.Contraseña);
        }

        public IMensaje NuevoMensaje(string pAsunto, ICollection<ICuenta> pDestinatario, string pContenido = "")
        {
            this.Mensajes.Add(CreadorMensajes.CrearMensaje(this, pAsunto, pDestinatario, pContenido));
            return this.Mensajes.Last();
        }
    }
}