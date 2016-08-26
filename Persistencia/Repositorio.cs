using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CapaInterfaces;
using System.Data.Entity;
using CapaInterfaces.Persistencia;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects.DataClasses;

namespace Persistencia
{
    public class Repositorio<TEntity> : IRepositorioCompleto<TEntity> where TEntity : class
    {
        protected IContext iContext;
        protected IDbSet<TEntity> iDbSet;

        public Repositorio(IUnitOfWork pUnitOfWork)
        {
            this.iContext = (IContext)pUnitOfWork.Context;
            this.iDbSet = ((DbContext)this.iContext).Set<TEntity>();
        }

        public int Agregar(TEntity entity)
        {
            iDbSet.Add(entity);
            return this.iContext.ObjectContext.SaveChanges();
        }

        public int Actualizar()
        {
            return this.iContext.ObjectContext.SaveChanges();
        }

        public int Eliminar(TEntity entity)
        {
            iDbSet.Remove(entity);
            return ((DbContext)this.iContext).SaveChanges();
        }

        public IEnumerable<TEntity> ObtenerSegun(Expression<Func<TEntity, bool>> criterio)
        {
            if (criterio == null)
                throw new ArgumentNullException("El criterio es nulo, no se puede evaluar la expresión");
            return iDbSet.Where(criterio);
        }

        public TEntity Obtener(Expression<Func<TEntity, bool>> criterio)
        {
            if (criterio == null)
                throw new ArgumentNullException("El criterio es nulo, no se puede evaluar la expresión");
           return iDbSet.SingleOrDefault(criterio);
        }

        public IEnumerable<TEntity> Todos()
        {
            return iDbSet;
        }
    }
}
