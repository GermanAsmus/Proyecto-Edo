﻿using System;
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
        public IRepositorio<T> Repositorio { get; }


        public ServicioAbstracto(IRepositorio<T> iRepositorio, IGestor pGestor)
        {
            this.Repositorio = iRepositorio;
            this.GestorServicio = pGestor;
        }

        public virtual Task<int> Editar(T entidad)
        {
            //var editarTask = 
            return Repositorio.Editar(entidad);
            //Task.WaitAll(editarTask);
            //if (editarTask.Result == 0)
            //    throw new ApplicationException("Editar");

            //return this;
        }
        public virtual Task Eliminar(Expression<Func<T, bool>> criterio)
        {
             return this.Obtener(criterio).ContinueWith((x)=> Repositorio.Agregar(x.Result));
            
            //var eliminarTask = Repositorio.Agregar(entidad);
            //Task.WaitAll(eliminarTask);
            //if (eliminarTask.Result == 0)
            //    throw new ApplicationException("Eliminar");
        }
        public virtual Task<IEnumerable<T>> Encontrar(Expression<Func<T, bool>> criterio)
        {
            //var encontrarTask = 
                return Repositorio.EncontrarAsync(criterio, CancellationToken.None);
            //Task.WaitAll(encontrarTask);
            //if (encontrarTask.Result == null)
            //    throw new ApplicationException("Encontrar");
            //else
            //    return encontrarTask.Result;
        }
        public virtual Task<T> Obtener(Expression<Func<T, bool>> criterio)
        {
            //var obtenerTask = 
               return Repositorio.ObtenerAsync(criterio, CancellationToken.None);
            //Task.WaitAll(obtenerTask);
            //if (obtenerTask.Result == null)
            //    throw new ApplicationException("Obtener");
            //else
            //    return obtenerTask.Result;
        }
        public virtual Task<IEnumerable<T>> ObtenerTodos()
        {
            //var obtenerTodosTask = 
              return Repositorio.ObtenerTodosAsync(CancellationToken.None);
            //Task.WaitAll(obtenerTodosTask);
            //if (obtenerTodosTask.Result == null)
            //    throw new ApplicationException("Obtener Todos");
            //else
            //    return obtenerTodosTask.Result;
        }
    }
}
