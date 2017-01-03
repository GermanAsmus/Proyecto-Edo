using EdoUI.Entidades;
using System;
using System.Linq.Expressions;

namespace Persistencia.Repositorios.CriteriosDeBusqueda
{
    public abstract class CriterioDeBusqueda<T> where T : IEntidadModelo
    {
        public static Func<T, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
    }
}
