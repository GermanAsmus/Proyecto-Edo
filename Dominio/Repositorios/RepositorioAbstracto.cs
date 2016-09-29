using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CapaInterfaces;
using CapaInterfaces.Dominio;
using Utilidades.CriteriosDeBusqueda;
using CapaInterfaces.Persistencia;

namespace Dominio.Repositorios
{
    /// <summary>
    /// Clase abstracta que define el implementa el comportamiento definido en las interfaces que implementa.
    /// Define su implementación de forma virtual y genérica.
    /// </summary>
    /// <typeparam name="T">Tipo de entidad de modelo</typeparam>
    public abstract class RepositorioAbstracto<T> : IRepositorioEstandar<T> where T : class, IEntidadModelo
    {
        ///// <summary>
        ///// Gestor de los repositorios, mantiene todos los repositorios que se definieron con anterioridad.
        ///// </summary>
        //public IGestorRespositorios GestorRepositorios { get; }
        /// <summary>
        /// Repositorio del tipo de la entidad de modelo.
        /// </summary>
        public IRepositorioCompleto<T> iRepositorio { get; }
        /// <summary>
        /// Constructor de la clase abstracta.
        /// </summary>
        /// <param name="pRepositorio">Repositorio del tipo de la entidad de modelo con que se define esta clase</param>
        /// <param name="pGestor">Gestor de los repositorios</param>
        public RepositorioAbstracto(IRepositorioCompleto<T> pRepositorio)//, IGestorRespositorios pGestor)
        {
            if (pRepositorio == null)
                throw new ArgumentNullException(nameof(pRepositorio));

            //if (pGestor == null)
            //    throw new ArgumentNullException(nameof(pGestor));

            this.iRepositorio = pRepositorio;
            //this.GestorRepositorios = pGestor;
        }
        /// <summary>
        /// Implementación virtual del método Actualizar.
        /// </summary>
        /// <returns>0 si se completó la operación, sino se realizó correctamente</returns>
        //public virtual int Actualizar()
        //{
        //    return iRepositorio.Actualizar();
        //}
        /// <summary>
        /// Implementación virtual del método Eliminar.
        /// </summary>
        /// <param name="pEntidad">entidad a eliminar</param>
        /// <returns>0 si se completó la operación, sino se realizó correctamente</returns>
        public virtual void Eliminar(T pEntidad)
        {
            iRepositorio.Eliminar(pEntidad);
        }
        /// <summary>
        /// Implementación virtual del método ObtenerSegun.
        /// Se busca un conjunto de elementos que cumplan con el criterio.
        /// </summary>
        /// <param name="pCriterio">Criterio de busqueda</param>
        /// <returns>Colección de las entidades encontradas</returns>
        public virtual IEnumerable<T> ObtenerSegun(Expression<Func<T,bool>> pCriterio)
        {
            return iRepositorio.ObtenerSegun(pCriterio);
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
        public virtual IEnumerable<T> Todos()
        {
              return iRepositorio.Todos();
        }

        //public int Agregar(DireccionCorreo pHijo, Cuenta pPadre)
        //{
        //    if (pHijo == null)
        //        throw new ArgumentNullException(nameof(pHijo));

        //    if (pPadre == null)
        //        throw new ArgumentNullException(nameof(pPadre));

        //    if (string.IsNullOrEmpty(pPadre.Contraseña) || string.IsNullOrEmpty(pPadre.Tipo))
        //        throw new NullReferenceException("Los atributos contraseña, nombre, no pueden ser nulos o vacíos");

        //    IRepositorioEstandar<DireccionCorreo> aRepositorioDireccion = this.GestorRepositorios.ObtenerRepositorio<DireccionCorreo>();

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
