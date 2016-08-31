using CapaInterfaces.Modelo;
using System;
using System.Linq.Expressions;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarCuenta : CriterioDeBusqueda<ICuentaDTO>
    {
        public new static Func<ICuentaDTO, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<ICuentaDTO, string, bool> BuscarPorNombre = (pEntidad, pNombre) => ((ICuentaUsuarioDTO)pEntidad).Nombre == pNombre;
        public static Func<ICuentaDTO, int, bool> BuscarPorDireccion = (pEntidad, pDireccionId) => pEntidad.DireccionId == pDireccionId;

    }
}
