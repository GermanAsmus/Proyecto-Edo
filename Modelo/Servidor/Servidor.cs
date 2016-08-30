using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    /// <summary>
    /// Entidad Servidor, modela un servidor de correo. Ej: gmail, yahoo, hotmail.
    /// </summary>
    public abstract class Servidor : IServidor
    {

        #region Propiedades
            //Nombre del servidor.
            public string Nombre { get; protected set; }
            //Protocolos de comunicacion del servidor
            protected IEnumerable<IProtocolo> Protocolos { get; set; }
        #endregion

        protected IServidorFactory iServidorFactory;

        protected virtual void RealizarServidor()
        {
            this.Protocolos = this.iServidorFactory.AgregarProtocolo();
        }

        //Constructor
        public Servidor(IServidorFactory pServidorFactory)
        {
            if (pServidorFactory != null)
            {
                this.iServidorFactory = pServidorFactory;
                this.RealizarServidor();
            }
            else
            {
                this.iServidorFactory = null;
                this.Protocolos = null;
            }
        }

        public virtual IProtocolo ObtenerProtocolo(string nombre)
        {
            return this.Protocolos.FirstOrDefault(p => p.Nombre == nombre.ToLower());
        }
    }
}
