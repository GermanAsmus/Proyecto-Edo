using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public int Agregar(TEntity entity)
        {
            iDbSet.Add(entity);
            return iEntities.SaveChanges();
        }

        public int Editar(TEntity entity)
        {
            iEntities.Entry(entity).State = EntityState.Modified;
            return iEntities.SaveChanges();
        }

        public int Eliminar(TEntity entity)
        {
            iDbSet.Remove(entity);
            return iEntities.SaveChanges();
        }

        public IEnumerable<TEntity> Encontrar(Expression<Func<TEntity, bool>> criterio)
        {
            return iDbSet.Where(criterio).ToList();
        }

        public TEntity Obtener(Expression<Func<TEntity, bool>> criterio)
        {
           return iDbSet.SingleOrDefault(criterio);
        }

        public IEnumerable<TEntity> ObtenerTodos()
        {
            return iDbSet.ToList();
        }
    }
}
