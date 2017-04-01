using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        private IDbSet<TEntity> iDbSet;
        private IDataContext iContext;

        public Repositorio(ref IDataContext pContext)
        {
            this.iContext = pContext;
            this.iDbSet = this.iContext.Context.Set<TEntity>();
        }

        public void Agregar(TEntity entity)
        {
            this.iDbSet.Add(entity);
            this.iContext.Commit();
        }

        public void Eliminar(TEntity entity)
        {
            this.iDbSet.Remove(entity);
            this.iContext.Commit();
        }

        public IEnumerable<TEntity> ObtenerTodos(Expression<Func<TEntity, bool>> criterio = null)
        {
            IQueryable<TEntity> mCopy = this.iDbSet;
            if (criterio == null)
                return mCopy;
            return mCopy.Where(criterio);
        }

        public TEntity ObtenerUno(Expression<Func<TEntity, bool>> criterio = null)
        {
            if (criterio == null)
                throw new ArgumentNullException("El criterio es nulo, no se puede evaluar la expresión");
            return this.iDbSet.SingleOrDefault(criterio);
        }
    }
}
