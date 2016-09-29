using CapaInterfaces;
using CapaInterfaces.Utilidades;
using System;
using System.Linq.Expressions;

namespace Utilidades.CriteriosDeBusqueda
{
    public abstract class CriterioDeBusqueda<T> : ICriterio<T> where T : IEntidadModelo 
    {
        public static Func<T, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
    }
}
