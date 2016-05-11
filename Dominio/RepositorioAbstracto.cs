using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ControlDependencia;
using ControlDependencia.Dominio;

namespace Dominio
{
    /// <summary>
    /// Clase abstracta que define el implementa el comportamiento definido en las interfaces que implementa.
    /// Define su implementación de forma virtual y genérica.
    /// </summary>
    /// <typeparam name="T">Tipo de entidad de modelo</typeparam>
    public abstract class RepositorioAbstracto<T> : IRepositorio<T>,IEstrategiaAgregar where T : class
    {
        /// <summary>
        /// Gestor de los repositorios, mantiene todos los repositorios que se definieron con anterioridad.
        /// </summary>
        public IGestorRespositorios GestorRepositorios { get; }
        /// <summary>
        /// Repositorio del tipo de la entidad de modelo.
        /// </summary>
        public IRepositorio<T> Repositorio { get; }
        /// <summary>
        /// Constructor de la clase abstracta.
        /// </summary>
        /// <param name="pRepositorio">Repositorio del tipo de la entidad de modelo con que se define esta clase</param>
        /// <param name="pGestor">Gestor de los repositorios</param>
        public RepositorioAbstracto(IRepositorio<T> pRepositorio, IGestorRespositorios pGestor)
        {
            if (pRepositorio == null)
                throw new ArgumentNullException(nameof(pRepositorio));

            if (pGestor == null)
                throw new ArgumentNullException(nameof(pGestor));

            this.Repositorio = pRepositorio;
            this.GestorRepositorios = pGestor;
        }

        int IRepositorio<T>.Agregar(T pEntidad)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Implementación virtual del método Editar.
        /// </summary>
        /// <param name="pEntidad">entidad a confirmar edición</param>
        /// <returns>0 si se completó la operación, sino se realizó correctamente</returns>
        public virtual int Editar(T pEntidad)
        {
            return Repositorio.Editar(pEntidad);
        }
        /// <summary>
        /// Implementación virtual del método Eliminar.
        /// </summary>
        /// <param name="pEntidad">entidad a eliminar</param>
        /// <returns>0 si se completó la operación, sino se realizó correctamente</returns>
        public virtual int Eliminar(T pEntidad)
        {
            return Repositorio.Eliminar(pEntidad);
        }
        /// <summary>
        /// Implementación virtual del método Encontrar.
        /// Se busca un conjunto de elementos que cumplan con el criterio.
        /// </summary>
        /// <param name="pCriterio">Criterio de busqueda</param>
        /// <returns>Colección de las entidades encontradas</returns>
        public virtual IEnumerable<T> Encontrar(Expression<Func<T,bool>> pCriterio)
        {
            return Repositorio.Encontrar(pCriterio);
        }
        /// <summary>
        /// Implementación virtual del método Obtener.
        /// Se obtiene la entidad que cumple con el criterio.
        /// </summary>
        /// <param name="pCriterio">Criterio de busqueda</param>
        /// <returns>Entidad obtenida</returns>
        public virtual T Obtener(Expression<Func<T, bool>> pCriterio)
        {
               return Repositorio.Obtener(pCriterio);
        }
        /// <summary>
        /// Implementación virtual del método ObtenerTodos.
        /// Obtiene todas las entidades del sistema.
        /// </summary>
        /// <returns>Colección de todas las entidaes del sistema</returns>
        public virtual IEnumerable<T> ObtenerTodos()
        {
              return Repositorio.ObtenerTodos();
        }
    }
}
