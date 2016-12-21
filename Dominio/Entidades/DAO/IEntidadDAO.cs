using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EdoUI.DTO;
using CapaInterfaces;

namespace Dominio.Entidades.DAO
{
    public interface IEntidadDAO<TEntity> : IObtenible<TEntity> where TEntity : IEntidadModelo
    {
        ICollection<TEntity> Agregar(TEntity pEntidad);
        ICollection<TEntity> Eliminar(Expression<Func<TEntity,bool>> pCriterio);
    }
}
