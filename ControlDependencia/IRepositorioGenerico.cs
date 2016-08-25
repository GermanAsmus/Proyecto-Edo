using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CapaInterfaces
{
    public interface IRepositorioGenerico<TEntity> : IRepositorioRaiz where TEntity : class
    {
        /// <summary>
        /// Elimina una instancia del tipo <typeparamref name="TEntity"/> que persistirá el repositorio
        /// </summary>
        /// <param name="pEntidad">entidad del tipo <typeparamref name="TEntity"/></param>
        /// <returns>void</returns>
        int Eliminar(TEntity pEntidad);
        /// <summary>
        /// Actualiza el repositorio;
        /// </summary>
        int Editar();
        /// <summary>
        /// Obtiene todas las entidades <typeparamref name="TEntity"/> que persisten en el repositorio
        /// </summary>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        IEnumerable<TEntity> ObtenerTodos();
        /// <summary>
        /// Obtiene todas las entidades <typeparamref name="TEntity"/> que cumplen con el <paramref name="pCriterio"/>
        /// que persisten en el repositorio
        /// </summary>
        /// <param name="pCriterio">pCriterio de busqueda</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        IEnumerable<TEntity> Encontrar(Expression<Func<TEntity, bool>> pCriterio);
        /// <summary>
        /// Obtiene la entidad <typeparamref name="TEntity"/> que cumple con el <paramref name="pCriterio"/>
        /// que persiste en el repositorio
        /// </summary>
        /// <param name="pCriterio">pCriterio de busqueda</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        TEntity Obtener(Expression<Func<TEntity, bool>> pCriterio);
    }
}
