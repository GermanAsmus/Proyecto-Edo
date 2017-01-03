using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioMensaje : IRepositorioCompleto<IMensajeDTO>
    {
        IMensajeDTO Obtener(int? pId);

        IMensajeDTO Obtener(string pAsunto = null);

        IEnumerable<IMensajeDTO> ObtenerSegun(int? pId);

        IEnumerable<IMensajeDTO> ObtenerSegun(string Asunto = null);
    }
}