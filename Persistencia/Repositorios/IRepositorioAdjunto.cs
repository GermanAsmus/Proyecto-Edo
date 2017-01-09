using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioAdjunto : IRepositorioCompleto<IAdjunto>
    {
        IAdjunto Obtener(int pId);


        IAdjunto Obtener(string pCodigo);


        IEnumerable<IAdjunto> ObtenerSegun(int? pId);


        IEnumerable<IAdjunto> ObtenerSegun(string pCodigo = null);
      
    }
}