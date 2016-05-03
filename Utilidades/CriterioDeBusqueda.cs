using ControlDependencia;
using Modelo;
using System;

namespace Utilidades
{
    public abstract class CriterioDeBusqueda<T> : ICriterio<T> where T : IEntidadModelo 
    {
        public static Func<T, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
    }
}
