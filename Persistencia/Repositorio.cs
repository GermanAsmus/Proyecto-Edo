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
        protected readonly IDbSet<TEntity> iDbSet;

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

        public IEnumerable<TEntity> ObtenerTodos()
        {
            return iDbSet;
        }
    }
}
