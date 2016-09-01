using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CapaInterfaces;

namespace Modelo
{
    public class EntidadDAO<TEntity> : IEntidadDAO<TEntity> where TEntity : IEntidadModelo
    {
        protected ICollection<TEntity> iColeccionFuente;

        public EntidadDAO(ICollection<TEntity> pColeccionFuente)
        {
            this.iColeccionFuente = pColeccionFuente;
        }

        public void Agregar(TEntity pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));
            this.iColeccionFuente.Add(pEntidad);
        }

        public void Eliminar(TEntity pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));
            this.iColeccionFuente.Remove(pEntidad);
        }
        public TEntity Obtener(Expression<Func<TEntity, bool>> pCriterio)
        {
            if (pCriterio == null)
                throw new ArgumentNullException(nameof(pCriterio));

            try
            {
                return this.iColeccionFuente.AsQueryable().SingleOrDefault(pCriterio);
            }
            catch (InvalidOperationException ex)
            {
                throw new CriterioException("El criterio es invalido, la operación fue cancelada", ex);
            }
            
        }
        public IEnumerable<TEntity> ObtenerSegun(Expression<Func<TEntity, bool>> pCriterio)
        {
            if(pCriterio==null)
                throw new ArgumentNullException(nameof(pCriterio));

            try
            {
                return this.iColeccionFuente.AsQueryable().Where(pCriterio);
            }
            catch (InvalidOperationException ex)
            {

                throw new CriterioException("El criterio es invalido, la operación fue cancelada", ex);
            }
            
        }
    }
}
