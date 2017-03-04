using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Repositorio<TEntity> where TEntity : class
    {
        private IDbSet<TEntity> iDbSet;
        private DbContext iDbContext;

        public Repositorio(ref IUnitOfWork pUnitofWork)
        {
            this.iDbContext = pUnitofWork.Context;
            this.iDbSet = this.iDbContext.Set<TEntity>();
        }

        public void Agregar(TEntity entity)
        {
            iDbSet.Add(entity);
        }

        public void Eliminar(TEntity entity)
        {
            iDbSet.Remove(entity);
        }

        public IEnumerable<TEntity> ObtenerTodos(Expression<Func<TEntity, bool>> criterio = null)
        {
            if (criterio == null)
                return iDbSet;
            return iDbSet.Where(criterio);
        }

        public TEntity ObtenerUno(Expression<Func<TEntity, bool>> criterio = null)
        {
            if (criterio == null)
                throw new ArgumentNullException("El criterio es nulo, no se puede evaluar la expresión");
            return iDbSet.SingleOrDefault(criterio);
        }

        public void Actualizar()
        {

        }
    }
}
