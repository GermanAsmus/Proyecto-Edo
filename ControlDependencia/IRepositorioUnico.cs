namespace CapaInterfaces
{
    public interface IRepositorioUnico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        /// <summary>
        /// Agrega una instancia del tipo <typeparamref name="TEntity"/>  que persistirá en el repositorio
        /// </summary>
        /// <param name="pEntidad">entidad del tipo <typeparamref name="TEntity"/> </param>
        int Agregar(TEntity pEntidad);
    }
}
