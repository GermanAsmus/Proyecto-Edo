using Modelo;

namespace ControlDependencia.Persistencia
{
    /// <summary>
    /// Unidad de trabajo, define los repositorios y mantiene el contexto de ejecución.
    /// </summary>
    public interface IUnitOfWork
    { 
        /// <summary>
        /// Repositorio de la entidad Cuenta.
        /// </summary>
        IRepositorio<Cuenta> RepositorioCuenta { get; set; }
        /// <summary>
        /// Repositorio de la entidad Mensaje.
        /// </summary>
        IRepositorio<Mensaje> RepositorioMensaje { get; set; }
        /// <summary>
        /// Repositorio de la entidad Servidor.
        /// </summary>
        IRepositorio<Servidor> RepositorioServidor { get; set; }
        /// <summary>
        /// Reposiotorio de la entidad DireccionCorreo
        /// </summary>
        IRepositorio<DireccionCorreo> RepositorioDireccionCorreo { get; set; }
        /// <summary>
        /// Reposiorio de la entidad Adjunto
        /// </summary>
        IRepositorio<Adjunto> RepositorioAdjunto { get; set; }
        /// <summary>
        /// Confirma los cambios realizados en el contexto. 
        /// </summary>
        /// <returns>0 si no se pudieron confirmar los cambios, sino se realizó correctamente</returns>
        int Commit();
    }
}
