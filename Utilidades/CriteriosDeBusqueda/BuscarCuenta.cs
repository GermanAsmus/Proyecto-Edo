using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.CriteriosDeBusqueda
{
    public class BuscarCuenta : CriterioDeBusqueda<Cuenta>
    {
        public new static Func<Cuenta, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<Cuenta, string, bool> BuscarPorNombre = (pEntidad, pNombre) => pEntidad.Nombre == pNombre;
        public static Func<Cuenta, int, bool> BuscarPorDireccion = (pEntidad, pDireccionId) => pEntidad.DireccionId == pDireccionId;
    }
}
