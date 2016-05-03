using Modelo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ControlDependencia
{
    public interface IRepositorio<TEntity> : IRepositorioRaiz where TEntity : class
    {
        /// <summary>
        /// Agrega una instancia del tipo <typeparamref name="TEntity"/>  que persistirá en el repositorio
        /// </summary>
        /// <param name="entity">entidad del tipo <typeparamref name="TEntity"/> </param>
        int Agregar(TEntity entity);
        /// <summary>
        /// Elimina una instancia del tipo <typeparamref name="TEntity"/> que persistirá el repositorio
        /// </summary>
        /// <param name="entity">entidad del tipo <typeparamref name="TEntity"/></param>
        /// <returns>void</returns>
        int Eliminar(TEntity entity);
        /// <summary>
        /// Actualiza una instancia del tipo <typeparamref name="TEntity"/> que ya existe en el repositorio que lo persiste
        /// </summary>
        /// <param name="entity">entidad del tipo <typeparamref name="TEntity"/></param>
        int Editar(TEntity entity);
        /// <summary>
        /// Obtiene todas las entidades <typeparamref name="TEntity"/> que persisten en el repositorio
        /// </summary>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        IEnumerable<TEntity> ObtenerTodos();
        /// <summary>
        /// Obtiene todas las entidades <typeparamref name="TEntity"/> que cumplen con el <paramref name="criterio"/>
        /// que persisten en el repositorio
        /// </summary>
        /// <param name="criterio">criterio de busqueda</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        IEnumerable<TEntity> Encontrar(Expression<Func<TEntity, bool>> criterio);
        /// <summary>
        /// Obtiene la entidad <typeparamref name="TEntity"/> que cumple con el <paramref name="criterio"/>
        /// que persiste en el repositorio
        /// </summary>
        /// <param name="criterio">criterio de busqueda</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        TEntity Obtener(Expression<Func<TEntity,bool>> criterio);
    }
}
