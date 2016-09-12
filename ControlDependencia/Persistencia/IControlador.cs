using CapaInterfaces.Modelo;

namespace CapaInterfaces.Persistencia
{
    public interface IControlador :
        IRepositorioCompleto<ICuentaDTO>,
        IRepositorioCompleto<IMensajeDTO>,
        IRepositorioCompleto<IAdjuntoDTO>,
        IRepositorioCompleto<IDireccionCorreoDTO>
    {
        int Actualizar();
    }
}
