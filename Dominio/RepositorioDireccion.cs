using ControlDependencia;
using ControlDependencia.Dominio;
using Modelo;
using System;
using Utilidades;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio
{
    public class RepositorioDireccion : RepositorioAbstracto<DireccionCorreo>, IEstrategiaAgregarSimple<DireccionCorreo>
    {
        public RepositorioDireccion(IRepositorio<DireccionCorreo> iRepositorio, IGestorRespositorios pGestor) : base(iRepositorio, pGestor)
        {

        }

        public int Agregar(DireccionCorreo pEntidad)
        {
            DireccionCorreo direccionResidente = this.Repositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorId(x, pEntidad.Id));
            if (direccionResidente != null)
               return this.Repositorio.Agregar(pEntidad);
            else
                throw new InvalidOperationException("ya existe la direccion en la bd");
        }
    }
}
