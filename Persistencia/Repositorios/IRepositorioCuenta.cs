using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioCuenta : IRepositorioCompleto<ICuenta>
    {
        ICuenta Obtener(int? pId);

        ICuenta Obtener(string pNombre = null);

        IEnumerable<ICuenta> ObtenerSegun(int? pId);

        IEnumerable<ICuenta> ObtenerSegun(string pNombre = null);
    }
}