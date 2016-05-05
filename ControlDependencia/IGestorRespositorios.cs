using System.Collections.Generic;
using System;

namespace ControlDependencia
{
    /// <summary>
    /// Interfaz que define al Gestor de Repositorios.
    /// </summary>
    public interface IGestorRespositorios
    {
        /// <summary>
        /// Diccionario con indice del tipo que manejará el repositorio y valor como el repositorio de dicho tipo.
        /// </summary>
        IDictionary<Type, IRepositorioRaiz> Repositorios { get; }
        /// <summary>
        /// Obtiene el repositorio de un tipo específico existente en el diccionario.
        /// </summary>
        /// <typeparam name="T">Tipo que define al repositorio</typeparam>
        /// <returns>repositorio del tipo T</returns>
        IRepositorio<T> ObtenerRepositorio<T>() where T : class;
    }
}
