using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CapaInterfaces;
using System.Data.Entity;
using CapaInterfaces.Persistencia;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects.DataClasses;

namespace Persistencia
{
    public abstract class Repositorio<TEntity> : IRepositorioCompleto<TEntity> where TEntity : class, IEntidadModelo
    {
        //Disparador para que UoW realize el commit.
        public Action Actualizar;

        private IDbSet<TEntity> iDbSet;



        public Repositorio(IDbSet<TEntity> pDbSet)
        {
            this.iDbSet = pDbSet;
        }

        public abstract void Agregar(TEntity entity);

        /// <summary>
        /// Agrega un elemento a la base de datos
        /// </summary>
        /// <param name="entity">entidad concreta del modelo</param>
        protected void AgregarEntidad(TEntity entity)
        {
            iDbSet.Add(entity);
            Actualizar();
        }

        public void Eliminar(TEntity entity)
        {
            iDbSet.Remove(entity);
            Actualizar();
        }

        public IEnumerable<TEntity> ObtenerSegun(Expression<Func<TEntity, bool>> criterio)
        {
            if (criterio == null)
                throw new ArgumentNullException("El criterio es nulo, no se puede evaluar la expresión");
            return iDbSet.Where(criterio);
        }

        public TEntity Obtener(Expression<Func<TEntity, bool>> criterio)
        {
            if (criterio == null)
                throw new ArgumentNullException("El criterio es nulo, no se puede evaluar la expresión");
           return iDbSet.SingleOrDefault(criterio);
        }

        public IEnumerable<TEntity> Todos()
        {
            return iDbSet;
        }
    }
}
