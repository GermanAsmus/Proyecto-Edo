using Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioMensaje : IRepositorioCompleto<IMensaje>
    {
        IMensaje Obtener(int? pId);

        IMensaje Obtener(string pAsunto = null);

        IEnumerable<IMensaje> ObtenerSegun(int? pId);

        IEnumerable<IMensaje> ObtenerSegun(string Asunto = null);
    }
}