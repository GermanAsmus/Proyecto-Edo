using Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioMensaje : IRepositorioCompleto<IMensaje>
    {
        IMensaje ObtenerUno(int? pId);

        IMensaje ObtenerUno(string pAsunto = null);

        IEnumerable<IMensaje> ObtenerTodos(int? pId);

        IEnumerable<IMensaje> ObtenerTodos(string Asunto = null);
    }
}