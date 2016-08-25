using System;

namespace Modelo
{
    public interface IRegistroMensaje
    {
        DateTime Fecha { get; }

        DateTime CambiarFecha(DateTime pNuevaFecha);

        bool NoEsNulo();
    }
}
