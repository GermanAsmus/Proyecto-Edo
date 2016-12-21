using EdoUI.DTO;

namespace Dominio.Entidades.DAO
{
    public interface IMensajeDAO : IEntidadDAO<ICuentaDTO>
    {
        IMensajeDTO MensajeDTO { get; set; }
        void CambiarEstadoPersistencia();
        string ObtenerEstadoPersistencia();

    }
}