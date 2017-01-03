using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioCuenta : IRepositorioCompleto<ICuentaDTO>
    {
        ICuentaDTO Obtener(int? pId);

        ICuentaDTO Obtener(string pNombre = null);

        IEnumerable<ICuentaDTO> ObtenerSegun(int? pId);

        IEnumerable<ICuentaDTO> ObtenerSegun(string pNombre = null);
    }
}