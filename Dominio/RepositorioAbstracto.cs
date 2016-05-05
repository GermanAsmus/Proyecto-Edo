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

        public RepositorioAbstracto(IRepositorio<T> pRepositorio, IGestorRespositorios pGestor)
        {
            if (pRepositorio == null)
                throw new ArgumentNullException(nameof(pRepositorio));

            if (pGestor == null)
                throw new ArgumentNullException(nameof(pGestor));

            this.Repositorio = pRepositorio;
            this.GestorServicio = pGestor;
        }
        int IRepositorio<T>.Agregar(T pEntidad)
        {
            throw new NotImplementedException();
        }
        public virtual int Editar(T pEntidad)
        {
            return Repositorio.Editar(pEntidad);
        }
        public virtual int Eliminar(T pEntidad)
        {
            return Repositorio.Eliminar(pEntidad);
        }
        public virtual IEnumerable<T> Encontrar(Expression<Func<T,bool>> pCriterio)
        {
            return Repositorio.Encontrar(pCriterio);
        }
        public virtual T Obtener(Expression<Func<T, bool>> pCriterio)
        {
               return Repositorio.Obtener(pCriterio);
        }
        public virtual IEnumerable<T> ObtenerTodos()
        {
              return Repositorio.ObtenerTodos();
        }
    }
}
