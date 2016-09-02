using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace Modelo
{
    /// <summary>
    /// Entidad ServidorDAO, modela un servidor de correo. Ej: gmail, yahoo, hotmail.
    /// </summary>
    public abstract class ServidorDAO : IEntidadDAO<IProtocoloDTO>, IServidorDAO
    {
        protected IEntidadDAO<IProtocoloDTO> iServicioControlProtocolos;

        public IServidorDTO ServidorDTO { get; set; }

        protected ServidorFactory iServidorFactory;

        protected void RealizarServidor()
        {
            this.iServicioControlProtocolos = new EntidadDAO<IProtocoloDTO>(new List<IProtocoloDTO>());
            this.ServidorDTO.Protocolos = this.iServidorFactory.AgregarEntidad();
        }

        //Constructor
        public ServidorDAO(ServidorFactory pServidorFactory)
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

        public void Agregar(IProtocoloDTO pEntidad)
        {
            iServicioControlProtocolos.Agregar(pEntidad);
        }

        public void Eliminar(IProtocoloDTO pEntidad)
        {
            iServicioControlProtocolos.Eliminar(pEntidad);
        }

        public IEnumerable<IProtocoloDTO> ObtenerSegun(Expression<Func<IProtocoloDTO, bool>> pCriterio)
        {
            return iServicioControlProtocolos.ObtenerSegun(pCriterio);
        }

        public IProtocoloDTO Obtener(Expression<Func<IProtocoloDTO, bool>> pCriterio)
        {
            return iServicioControlProtocolos.Obtener(pCriterio);
        }
    }
}
