using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ControlDependencia;

namespace Dominio
{
    public abstract class RepositorioAbstracto<T> : IRepositorio<T>,IEstrategiaAgregar where T : class
    {
        public IGestorRespositorios GestorServicio { get; }
        public IRepositorio<T> Repositorio { get; }

        public RepositorioAbstracto(IRepositorio<T> iRepositorio, IGestorRespositorios pGestor)
        {
            this.Repositorio = iRepositorio;
        }
        int IRepositorio<T>.Agregar(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual int Editar(T entidad)
        {
            return Repositorio.Editar(entidad);
        }
        public virtual int Eliminar(T entidad)
        {
            return Repositorio.Eliminar(entidad);
        }
        public virtual IEnumerable<T> Encontrar(Expression<Func<T,bool>> criterio)
        {
            return Repositorio.Encontrar(criterio);
        }
        public virtual T Obtener(Expression<Func<T, bool>> criterio)
        {
               return Repositorio.Obtener(criterio);
        }
        public virtual IEnumerable<T> ObtenerTodos()
        {
              return Repositorio.ObtenerTodos();
        }
    }
}
