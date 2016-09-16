using System;
using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IMensajeDAO : IEntidadDAO<ICuentaDTO>
    {
        IMensajeDTO MensajeDTO { get; set; }
        void CambiarEstadoPersistencia();
        string ObtenerEstadoPersistencia();

    }
}