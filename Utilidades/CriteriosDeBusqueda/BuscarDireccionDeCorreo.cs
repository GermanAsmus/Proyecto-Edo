using CapaInterfaces.Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarDireccionDeCorreo : CriterioDeBusqueda<IDireccionCorreo>
    {
        public new static Func<IDireccionCorreo, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IDireccionCorreo, string, bool> BuscarPorDireccion = (pEntidad, pDireccion) => pEntidad.DireccionDeCorreo == pDireccion;
        public static Func<IDireccionCorreo, int, bool> BuscarPorCuentaId = (pEntidad, pCuentaId) => pEntidad.CuentaId == pCuentaId;
    }
}
