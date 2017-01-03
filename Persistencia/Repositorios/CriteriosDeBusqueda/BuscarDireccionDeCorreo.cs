using EdoUI.Entidades.DTO;
using System;

namespace Persistencia.Repositorios.CriteriosDeBusqueda
{
    public class BuscarDireccionDeCorreo : CriterioDeBusqueda<IDireccionCorreoDTO>
    {
        public new static Func<IDireccionCorreoDTO, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<IDireccionCorreoDTO, string, bool> BuscarPorDireccion = (pEntidad, pDireccion) => pEntidad.DireccionDeCorreo == pDireccion;
        public static Func<IDireccionCorreoDTO, int, bool> BuscarPorCuentaId = (pEntidad, pCuentaId) => pEntidad.CuentaId == pCuentaId;
    }
}
