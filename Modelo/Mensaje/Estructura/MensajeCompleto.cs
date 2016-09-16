using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeCompleto : MensajeDAO, IMensajeCompletoDAO, IEntidadDAO<IAdjuntoDTO>
    {
        private EntidadDAO<IAdjuntoDTO> iServicioControlAdjuntos;

        //public MensajeCompleto(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        public MensajeCompleto(IMensajeCompletoDTO pMensajeDTO) : base(pMensajeDTO)
        {
            this.iServicioControlAdjuntos = new EntidadDAO<IAdjuntoDTO>(new List<IAdjuntoDTO>());
        }

        public new IMensajeDTO MensajeDTO
        {
            get
            {
                return base.MensajeDTO as IMensajeCompletoDTO;
            }

            set
            {
                base.MensajeDTO = value as IMensajeCompletoDTO;
            }
        }

        public ICollection<IAdjuntoDTO> Agregar(IAdjuntoDTO pEntidad)
        {
            (this.MensajeDTO as IMensajeCompletoDTO).Adjuntos = this.iServicioControlAdjuntos.Agregar(pEntidad);

            return (this.MensajeDTO as IMensajeCompletoDTO).Adjuntos;
        }

        public ICollection<IAdjuntoDTO> Eliminar(Expression<Func<IAdjuntoDTO, bool>> pCriterio)
        {
            (this.MensajeDTO as IMensajeCompletoDTO).Adjuntos = this.iServicioControlAdjuntos.Eliminar(pCriterio);

            return (this.MensajeDTO as IMensajeCompletoDTO).Adjuntos;
        }

        public IAdjuntoDTO Obtener(Expression<Func<IAdjuntoDTO, bool>> pCriterio)
        {
            return this.iServicioControlAdjuntos.Obtener(pCriterio);
        }

        public IEnumerable<IAdjuntoDTO> ObtenerSegun(Expression<Func<IAdjuntoDTO, bool>> pCriterio)
        {
            return this.iServicioControlAdjuntos.ObtenerSegun(pCriterio);
        }
    }
}
