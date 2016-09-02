using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeCompletoDAO : MensajeEstructuradoDAO, IEntidadDAO<AdjuntoDTO>
    {
        private EntidadDAO<AdjuntoDTO> iServicioControlAdjuntos;

        public MensajeCompletoDAO(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
            this.iServicioControlAdjuntos = new EntidadDAO<AdjuntoDTO>(new List<AdjuntoDTO>());
        }

        public override IMensajeDTO MensajeDTO
        {
            get
            {
                return base.MensajeDTO as MensajeCompletoDTO;
            }

            set
            {
                base.MensajeDTO = value as MensajeCompletoDTO;
            }
        }

        public void Agregar(AdjuntoDTO pEntidad)
        {
            this.iServicioControlAdjuntos.Agregar(pEntidad);
        }

        public void Eliminar(AdjuntoDTO pEntidad)
        {
            this.iServicioControlAdjuntos.Eliminar(pEntidad);
        }

        public AdjuntoDTO Obtener(Expression<Func<AdjuntoDTO, bool>> pCriterio)
        {
            return this.iServicioControlAdjuntos.Obtener(pCriterio);
        }

        public IEnumerable<AdjuntoDTO> ObtenerSegun(Expression<Func<AdjuntoDTO, bool>> pCriterio)
        {
            return this.iServicioControlAdjuntos.ObtenerSegun(pCriterio);
        }
    }
}
