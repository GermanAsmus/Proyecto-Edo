using EdoUI.Entidades;

namespace Persistencia.Repositorios
{
    public interface IRepositorioCompleto<TEntity> : IRepositorioEstandar<TEntity> where TEntity : class, IEntidadModelo
    {
        /// <summary>
        /// Agrega una instancia del tipo <typeparamref name="TEntity"/>  que persistirá en el repositorio
        /// </summary>
        /// <param name="pEntidad">entidad del tipo <typeparamref name="TEntity"/> </param>
        void Agregar(TEntity pEntidad);
    }
}
