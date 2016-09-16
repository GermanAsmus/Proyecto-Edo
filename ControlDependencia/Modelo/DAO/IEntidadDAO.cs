using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface IEntidadDAO<TEntity> : IObtenible<TEntity> where TEntity : IEntidadModelo
    {
        ICollection<TEntity> Agregar(TEntity pEntidad);
        ICollection<TEntity> Eliminar(Expression<Func<TEntity,bool>> pCriterio);
    }
}
