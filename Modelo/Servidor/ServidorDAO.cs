using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Modelo
{
    /// <summary>
    /// Entidad ServidorDAO, modela un servidor de correo. Ej: gmail, yahoo, hotmail.
    /// </summary>
    public abstract class ServidorDAO : EntidadDAO<IProtocoloDTO>, IServidorDAO
    {
        public IServidorDTO ServidorDTO { get; set; }

        protected IServidorFactory iServidorFactory;

        protected void RealizarServidor()
        {
            this.ServidorDTO.Protocolos = this.iServidorFactory.AgregarProtocolo();
        }

        //Constructor
        public ServidorDAO(IServidorFactory pServidorFactory)
        {
            this.ServidorDTO = new ServidorDTO();
            this.iServidorFactory = pServidorFactory; //Si el parametro es nulo, el servidor será del tipo nulo.
            if (this.iServidorFactory != null)
                this.RealizarServidor();
                
        }

        public virtual IProtocoloDTO ObtenerProtocolo(string nombre)
        {
            return this.ServidorDTO.Protocolos.FirstOrDefault(p => p.Nombre == nombre.ToLower());
        }

        IProtocoloDTO IServidorDAO.ObtenerProtocolo(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
