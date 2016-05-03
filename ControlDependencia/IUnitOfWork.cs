using Modelo;

namespace ControlDependencia
{
    public interface IUnitOfWork
    {
        IRepositorio<Cuenta> RepositorioCuenta { get; set; }
        IRepositorio<Mensaje> RepositorioMensaje { get; set; }
        IRepositorio<Servidor> RepositorioServidor { get; set; }
        IRepositorio<DireccionCorreo> RepositorioDireccionCorreo { get; set; }
        IRepositorio<Adjunto> RepositorioAdjunto { get; set; }

        int Commit();
    }
}
