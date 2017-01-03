using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioAdjunto : IRepositorioCompleto<IAdjuntoDTO>
    {
        IAdjuntoDTO Obtener(int pId);


        IAdjuntoDTO Obtener(string pCodigo);


        IEnumerable<IAdjuntoDTO> ObtenerSegun(int? pId);


        IEnumerable<IAdjuntoDTO> ObtenerSegun(string pCodigo = null);
      
    }
}