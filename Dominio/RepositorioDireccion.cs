using ControlDependencia;
using ControlDependencia.Dominio;
using Modelo;
using System;
using Utilidades;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio
{
    public class RepositorioDireccion : RepositorioAbstracto<DireccionCorreo>, IRepositorioUnico<DireccionCorreo>
    {
        public RepositorioDireccion(IRepositorioUnico<DireccionCorreo> pRepositorioInterno) : base(pRepositorioInterno)
        {

        }

        public int Agregar(DireccionCorreo pEntidad)
        {
            if(pEntidad==null)
                throw new ArgumentNullException(nameof(pEntidad));

            DireccionCorreo iDireccion = this.iRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorId(x, pEntidad.Id));
            if (iDireccion != null)
               return this.iRepositorio.Agregar(pEntidad);
            else
                throw new InvalidOperationException("ya existe la direccion en la bd");
        }
    }
}
