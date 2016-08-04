using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ControlDependencia;
using ControlDependencia.Dominio;
using Modelo;
using Utilidades.CriteriosDeBusqueda;
using ControlDependencia.Persistencia;

namespace Dominio.Repositorios
{
    /// <summary>
    /// Clase abstracta que define el implementa el comportamiento definido en las interfaces que implementa.
    /// Define su implementación de forma virtual y genérica.
    /// </summary>
    /// <typeparam name="T">Tipo de entidad de modelo</typeparam>
    public abstract class RepositorioAbstracto<T> : IRepositorioGenerico<T> where T : class
    {
        ///// <summary>
        ///// Gestor de los repositorios, mantiene todos los repositorios que se definieron con anterioridad.
        ///// </summary>
        //public IGestorRespositorios GestorRepositorios { get; }
        /// <summary>
        /// Repositorio del tipo de la entidad de modelo.
        /// </summary>
        public IRepositorioUnico<T> iRepositorio { get; }
        /// <summary>
        /// Constructor de la clase abstracta.
        /// </summary>
        /// <param name="pRepositorio">Repositorio del tipo de la entidad de modelo con que se define esta clase</param>
        /// <param name="pGestor">Gestor de los repositorios</param>
        public RepositorioAbstracto(IRepositorioUnico<T> pRepositorio)//, IGestorRespositorios pGestor)
        {
            if (pRepositorio == null)
                throw new ArgumentNullException(nameof(pRepositorio));

            //if (pGestor == null)
            //    throw new ArgumentNullException(nameof(pGestor));

            this.iRepositorio = pRepositorio;
            //this.GestorRepositorios = pGestor;
        }
        /// <summary>
        /// Implementación virtual del método Editar.
        /// </summary>
        /// <returns>0 si se completó la operación, sino se realizó correctamente</returns>
        public virtual int Editar()
        {
            return iRepositorio.Editar();
        }
        /// <summary>
        /// Implementación virtual del método Eliminar.
        /// </summary>
        /// <param name="pEntidad">entidad a eliminar</param>
        /// <returns>0 si se completó la operación, sino se realizó correctamente</returns>
        public virtual int Eliminar(T pEntidad)
        {
            return iRepositorio.Eliminar(pEntidad);
        }
        /// <summary>
        /// Implementación virtual del método Encontrar.
        /// Se busca un conjunto de elementos que cumplan con el criterio.
        /// </summary>
        /// <param name="pCriterio">Criterio de busqueda</param>
        /// <returns>Colección de las entidades encontradas</returns>
        public virtual IEnumerable<T> Encontrar(Expression<Func<T,bool>> pCriterio)
        {
            return iRepositorio.Encontrar(pCriterio);
        }
        /// <summary>
        /// Implementación virtual del método Obtener.
        /// Se obtiene la entidad que cumple con el criterio.
        /// </summary>
        /// <param name="pCriterio">Criterio de busqueda</param>
        /// <returns>Entidad obtenida</returns>
        public virtual T Obtener(Expression<Func<T, bool>> pCriterio)
        {
               return iRepositorio.Obtener(pCriterio);
        }
        /// <summary>
        /// Implementación virtual del método ObtenerTodos.
        /// Obtiene todas las entidades del sistema.
        /// </summary>
        /// <returns>Colección de todas las entidaes del sistema</returns>
        public virtual IEnumerable<T> ObtenerTodos()
        {
              return iRepositorio.ObtenerTodos();
        }

        //public int Agregar(DireccionCorreo pHijo, Cuenta pPadre)
        //{
        //    if (pHijo == null)
        //        throw new ArgumentNullException(nameof(pHijo));

        //    if (pPadre == null)
        //        throw new ArgumentNullException(nameof(pPadre));

        //    if (string.IsNullOrEmpty(pPadre.Contraseña) || string.IsNullOrEmpty(pPadre.Nombre))
        //        throw new NullReferenceException("Los atributos contraseña, nombre, no pueden ser nulos o vacíos");

        //    IRepositorioGenerico<DireccionCorreo> aRepositorioDireccion = this.GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();

        //    DireccionCorreo iDireccion = aRepositorioDireccion.Obtener(direccion => BuscarDireccionDeCorreo.BuscarPorDireccion(direccion, pHijo.DireccionDeCorreo));
        //    //De no existir la direccion, se agrega a la base de datos
        //    if (iDireccion == null)
        //        aRepositorioDireccion.Agregar(pHijo);

        //    iDireccion.Cuenta = pPadre;
        //    iDireccion.CuentaId = pPadre.Id;
        //    pPadre.DireccionId = iDireccion.Id;

        //    //Cargar el Servidor
        //    Servidor iServidor = new Servidor();
        //    pPadre.Servidor = iServidor;

        //    Repositorio.Agregar(pPadre);
        //}
    }
}
