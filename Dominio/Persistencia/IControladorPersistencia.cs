using EdoUI.DTO;
using Dominio.Persistencia.Repositorio;

namespace Dominio.Persistencia
{
    public interface IControladorPersistencia :
        IRepositorioCompleto<ICuentaDTO>,
        IRepositorioCompleto<IMensajeDTO>,
        IRepositorioCompleto<IAdjuntoDTO>,
        IRepositorioCompleto<IDireccionCorreoDTO>
    {
        int Actualizar();
    }
}
