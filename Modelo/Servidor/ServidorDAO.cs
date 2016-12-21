using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace Persistencia
{
    /// <summary>
    /// Entidad ServidorDAO, modela un servidor de correo. Ej: gmail, yahoo, hotmail.
    /// </summary>
    public class ServidorDAO : IServidorDAO
    {
        protected IEntidadDAO<IProtocoloDTO> iServicioControlProtocolos;

        public IServidorDTO ServidorDTO { get; set; }

        //Constructor
        public ServidorDAO(IServidorDTO pServidorDTO)
        {
            this.ServidorDTO = pServidorDTO;
            this.iServicioControlProtocolos = new EntidadDAO<IProtocoloDTO>(this.ServidorDTO.Protocolos);
        }

        #region Control protocolos
        public ICollection<IProtocoloDTO> Agregar(IProtocoloDTO pEntidad)
        {
            this.ServidorDTO.Protocolos = iServicioControlProtocolos.Agregar(pEntidad);
            return this.ServidorDTO.Protocolos;
        }

        public ICollection<IProtocoloDTO> Eliminar(Expression<Func<IProtocoloDTO, bool>> pCriterio)
        {
            this.ServidorDTO.Protocolos = iServicioControlProtocolos.Eliminar(pCriterio);
            return this.ServidorDTO.Protocolos;

        }

        public IEnumerable<IProtocoloDTO> ObtenerSegun(Expression<Func<IProtocoloDTO, bool>> pCriterio)
        {
            return iServicioControlProtocolos.ObtenerSegun(pCriterio);
        }

        public IProtocoloDTO Obtener(Expression<Func<IProtocoloDTO, bool>> pCriterio)
        {
            return iServicioControlProtocolos.Obtener(pCriterio);
        } 
        #endregion

    }
}
