using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ControlDependencia;
using System.Data.Entity;

namespace Persistencia
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {

        protected DbContext iEntities;
        protected readonly DbSet<TEntity> iDbSet;

        public Repositorio(EntityFrameworkDBContext context)
        {
            iEntities = context;
            iDbSet = context.Set<TEntity>();
        }

        public Task<int> Agregar(TEntity entity)
        {
            iDbSet.Add(entity);
            return iEntities.SaveChangesAsync();
        }

        public Task<int> Editar(TEntity entity)
        {
            iEntities.Entry(entity).State = EntityState.Modified;
            return iEntities.SaveChangesAsync();
        }

        public Task<int> Eliminar(TEntity entity)
        {
            iDbSet.Remove(entity);
            return iEntities.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> EncontrarAsync(Expression<Func<TEntity, bool>> criterio, CancellationToken token)
        {
            return await iDbSet.Where(criterio).ToListAsync(token);
        }

        public async Task<TEntity> ObtenerAsync(Expression<Func<TEntity, bool>> criterio, CancellationToken token)
        {
           return await iDbSet.SingleOrDefaultAsync(criterio, token);
        }

        public async Task<IEnumerable<TEntity>> ObtenerTodosAsync(CancellationToken token)
        {
            return await iDbSet.ToListAsync(token);
        }
    }
}
