using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataLayer
{
    internal interface IRepositorio<TEntity> where TEntity : class
    {
        void Agregar(TEntity entity);
        void Eliminar(TEntity entity);
        IEnumerable<TEntity> ObtenerTodos(Expression<Func<TEntity, bool>> criterio = null);
        TEntity ObtenerUno(Expression<Func<TEntity, bool>> criterio = null);
    }
}