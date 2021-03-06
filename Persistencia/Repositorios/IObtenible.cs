﻿using EdoUI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dominio
{
    public interface IObtenible<TEntity> where TEntity : IEntidadModelo
    {
       
        /// <summary>
        /// Obtiene todas las entidades <typeparamref name="TEntity"/> que cumplen con el <paramref name="pCriterio"/>
        /// que persisten en el repositorio
        /// </summary>
        /// <param name="pCriterio">pCriterio de busqueda</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        //IEnumerable<TEntity> ObtenerSegun(Expression<Func<TEntity, bool>> pCriterio);
        IEnumerable<TEntity> ObtenerSegun(Expression<Func<TEntity, bool>> pCriterio);


        /// <summary>
        /// Obtiene la entidad <typeparamref name="TEntity"/> que cumple con el <paramref name="pCriterio"/>
        /// que persiste en el repositorio
        /// </summary>
        /// <param name="pCriterio">pCriterio de busqueda</param>
        /// <returns>Coleccion enumerable de las entidades obtenidas</returns>
        TEntity Obtener(Expression<Func<TEntity, bool>> pCriterio);

    }
}
