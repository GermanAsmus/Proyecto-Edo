using CapaInterfaces;
using CapaInterfaces.Dominio;
using CapaInterfaces.Modelo;
using System;
using Utilidades;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio.Repositorios
{
    public class RepositorioDireccion : RepositorioAbstracto<IDireccionCorreoDTO>, IRepositorioCompleto<IDireccionCorreoDTO>
    {
        public RepositorioDireccion(IRepositorioCompleto<IDireccionCorreoDTO> pRepositorioInterno) : base(pRepositorioInterno)
        {

        }

        public int Agregar(IDireccionCorreoDTO pEntidad)
        {
            if(pEntidad==null)
                throw new ArgumentNullException(nameof(pEntidad));

            IDireccionCorreoDTO iDireccion = this.iRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorId(x, pEntidad.Id));
            if (iDireccion != null)
               return this.iRepositorio.Agregar(pEntidad);
            else
                throw new InvalidOperationException("ya existe la direccion en la bd");
        }
    }
}
