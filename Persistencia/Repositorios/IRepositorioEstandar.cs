using EdoUI.Entidades;

namespace Persistencia.Repositorios
{
    public interface IRepositorioEstandar<TEntity> : IRepositorioRaiz where TEntity : class, IEntidadModelo
    {

        /// <summary>
        /// Elimina una instancia del tipo <typeparamref name="TEntity"/> que persistirá el repositorio
        /// </summary>
        /// <param name="pEntidad">entidad del tipo <typeparamref name="TEntity"/></param>
        /// <returns>void</returns>
        void Eliminar(TEntity pEntidad);
    }
}
