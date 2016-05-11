using Modelo;
using System;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarDireccionDeCorreo : CriterioDeBusqueda<DireccionCorreo>
    {
        public new static Func<DireccionCorreo, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<DireccionCorreo, string, bool> BuscarPorDireccion = (pEntidad, pDireccion) => pEntidad.DireccionDeCorreo == pDireccion;
        public static Func<DireccionCorreo, int, bool> BuscarPorCuentaId = (pEntidad, pCuentaId) => pEntidad.CuentaId == pCuentaId;
    }
}
