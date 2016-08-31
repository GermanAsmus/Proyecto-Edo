using System;
using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IMensajeDAO
    {
        void CambiarEstadoPersistencia();
        string ObtenerEstadoPersistencia();

    }
}