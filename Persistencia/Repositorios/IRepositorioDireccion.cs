using Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioDireccion : IRepositorioCompleto<IDireccionCorreo>
    {
        IDireccionCorreo ObtenerUno(int? pId);

        IDireccionCorreo ObtenerUno(string pDireccion = null);

        IEnumerable<IDireccionCorreo> ObtenerTodos(int? pId);

        IEnumerable<IDireccionCorreo> ObtenerTodos(string pDireccion = null);
    }
}