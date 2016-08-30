using System;

namespace Modelo
{
    public interface IRegistroMensaje<T> where T : struct, IConvertible
    {        
        DateTime Fecha { get; }

        T Registro { get; }

        bool NoEsNulo();
    }
}
