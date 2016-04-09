using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlDependencia
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        /// <summary>
        /// Agrega una instancia del tipo <typeparamref name="TEntity"/>  que persistirá en el repositorio
        /// </summary>
        /// <param name="entity">entidad del tipo <typeparamref name="TEntity"/> </param>
        /// <returns>void</returns>
        Task<int> Agregar(TEntity entity);
        /// <summary>
        /// Elimina una instancia del tipo <typeparamref name="TEntity"/> que persistirá el repositorio
        /// </summary>
        /// <param name="entity">entidad del tipo <typeparamref name="TEntity"/></param>
        /// <returns>void</returns>
        Task<int> Eliminar(TEntity entity);
        /// <summary>
        /// Actualiza una instancia del tipo <typeparamref name="TEntity"/> que ya existe en el repositorio que lo persiste
        /// </summary>
        /// <param name="entity">entidad del tipo <typeparamref name="TEntity"/></param>
        /// <returns>void</returns>
        Task<int> Editar(TEntity entity);
        /// <summary>
        /// Obtiene todas las entidades <typeparamref name="TEntity"/> que persisten en el repositorio
        /// </summary>
        /// <param name="token">token de cancelacion</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        Task<IEnumerable<TEntity>> ObtenerTodosAsync(CancellationToken token);
        /// <summary>
        /// Obtiene todas las entidades <typeparamref name="TEntity"/> que cumplen con el <paramref name="criterio"/>
        /// que persisten en el repositorio
        /// </summary>
        /// <param name="criterio">criterio de busqueda</param>
        /// <param name="token">token de cancelacion</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        Task<IEnumerable<TEntity>> EncontrarAsync(Expression<Func<TEntity, bool>> criterio, CancellationToken token);
        /// <summary>
        /// Obtiene la entidad <typeparamref name="TEntity"/> que cumple con el <paramref name="criterio"/>
        /// que persiste en el repositorio
        /// </summary>
        /// <param name="criterio">criterio de busqueda</param>
        /// <param name="token">token de cancelacion</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        Task<TEntity> ObtenerAsync(Expression<Func<TEntity, bool>> criterio, CancellationToken token);
    }
}
