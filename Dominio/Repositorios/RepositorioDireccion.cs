using CapaInterfaces;
using CapaInterfaces.Dominio;
using CapaInterfaces.Modelo;
using System;
using Utilidades;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio.Repositorios
{
    public class RepositorioDireccion : RepositorioAbstracto<IDireccionCorreo>, IRepositorioUnico<IDireccionCorreo>
    {
        public RepositorioDireccion(IRepositorioUnico<IDireccionCorreo> pRepositorioInterno) : base(pRepositorioInterno)
        {

        }

        public int Agregar(IDireccionCorreo pEntidad)
        {
            if(pEntidad==null)
                throw new ArgumentNullException(nameof(pEntidad));

            IDireccionCorreo iDireccion = this.iRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorId(x, pEntidad.Id));
            if (iDireccion != null)
               return this.iRepositorio.Agregar(pEntidad);
            else
                throw new InvalidOperationException("ya existe la direccion en la bd");
        }
    }
}
