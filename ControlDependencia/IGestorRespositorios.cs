using System.Collections.Generic;
using System;

namespace ControlDependencia
{
    public interface IGestorRespositorios
    {
        IDictionary<Type, IRepositorioRaiz> Repositorios { get; }
        IRepositorio<T> ObtenerRepositorio<T>() where T : class;
    }
}
