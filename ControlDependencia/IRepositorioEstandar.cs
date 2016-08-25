using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CapaInterfaces
{
    public interface IRepositorioEstandar<TEntity> : IRepositorioRaiz, IObtenible<TEntity> where TEntity : class
    {
        
        /// <summary>
        /// Actualiza el repositorio;
        /// </summary>
        int Actualizar();
        /// <summary>
        /// Elimina una instancia del tipo <typeparamref name="TEntity"/> que persistirá el repositorio
        /// </summary>
        /// <param name="pEntidad">entidad del tipo <typeparamref name="TEntity"/></param>
        /// <returns>void</returns>
        int Eliminar(TEntity pEntidad);
        
    }
}
