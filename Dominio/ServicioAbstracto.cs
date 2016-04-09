using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ControlDependencia;
using System.Threading;

namespace Dominio
{
    public abstract class ServicioAbstracto<T> : IServicio<T> where T : class
    {
        public IGestor GestorServicio { get; }
        public IRepositorio<T> Repositorio { get;}

    
        public ServicioAbstracto(IRepositorio<T> iRepositorio)
        {
            this.Repositorio = iRepositorio;
        }

        public virtual IServicioRaiz Editar(T entidad)
        {
            var editarTask = Repositorio.Editar(entidad);
            Task.WaitAll(editarTask);
            if (editarTask.Result == 0)
                throw new ApplicationException("Editar");

            return this;
        }
        public virtual void Eliminar(Expression<Func<T, bool>> criterio)
        {
            T entidad = this.Obtener(criterio);

            var eliminarTask = Repositorio.Agregar(entidad);
            Task.WaitAll(eliminarTask);
            if (eliminarTask.Result == 0)
                throw new ApplicationException("Eliminar");
        }
        public virtual IEnumerable<T> Encontrar(Expression<Func<T, bool>> criterio)
        {
            var encontrarTask = Repositorio.EncontrarAsync(criterio, CancellationToken.None);
            Task.WaitAll(encontrarTask);
            if (encontrarTask.Result == null)
                throw new ApplicationException("Encontrar");
            else
                return encontrarTask.Result;
        }
        public virtual T Obtener(Expression<Func<T, bool>> criterio)
        {
            var obtenerTask = Repositorio.ObtenerAsync(criterio, CancellationToken.None);
            Task.WaitAll(obtenerTask);
            if (obtenerTask.Result == null)
                throw new ApplicationException("Obtener");
            else
                return obtenerTask.Result;
        }
        public virtual IEnumerable<T> ObtenerTodos()
        {
            var obtenerTodosTask = Repositorio.ObtenerTodosAsync(CancellationToken.None);
            Task.WaitAll(obtenerTodosTask);
            if (obtenerTodosTask.Result == null)
                throw new ApplicationException("Obtener Todos");
            else
                return obtenerTodosTask.Result;
        }

        IServicioRaiz IServicio<T>.Editar(T entidad)
        {
            throw new NotImplementedException();
        }

        void IServicio<T>.Eliminar(Expression<Func<T, bool>> criterio)
        {
            throw new NotImplementedException();
        }

        T IServicio<T>.Obtener(Expression<Func<T, bool>> criterio)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IServicio<T>.ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IServicio<T>.Encontrar(Expression<Func<T, bool>> criterio)
        {
            throw new NotImplementedException();
        }
    }
}
