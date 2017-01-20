using Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioDireccion : IRepositorioCompleto<IDireccionCorreo>
    {
        IDireccionCorreo Obtener(int? pId);

        IDireccionCorreo Obtener(string pDireccion = null);

        IEnumerable<IDireccionCorreo> ObtenerSegun(int? pId);

        IEnumerable<IDireccionCorreo> ObtenerSegun(string pDireccion = null);
    }
}