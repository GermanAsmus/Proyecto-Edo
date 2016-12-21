using EdoUI.DTO;

namespace Dominio.Entidades.DAO
{
    public interface IServidorDAO : IEntidadDAO<IProtocoloDTO>
    {
        IServidorDTO ServidorDTO { get; set; }
    }
}
