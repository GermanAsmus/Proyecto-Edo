using EdoUI.DTO;

namespace Dominio.Entidades.DAO
{
    public interface ICuentaDAO : IEntidadDAO<IMensajeDTO>
    {
        ICuentaDTO Cuenta { get; set; }
    }
}
