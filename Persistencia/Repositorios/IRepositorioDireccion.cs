using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioDireccion : IRepositorioCompleto<IDireccionCorreoDTO>
    {
        IDireccionCorreoDTO Obtener(int? pId);

        IDireccionCorreoDTO Obtener(string pDireccion = null);

        IEnumerable<IDireccionCorreoDTO> ObtenerSegun(int? pId);

        IEnumerable<IDireccionCorreoDTO> ObtenerSegun(string pDireccion = null);
    }
}