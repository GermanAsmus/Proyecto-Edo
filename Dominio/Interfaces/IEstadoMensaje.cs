using System;

namespace Dominio.Entidades.Interfaces
{
    public interface IEstadoMensaje
    {
        string EstadoGuardado { get; set; }
        string EstadoEnviado { get; set; }
        string EstadoVisto { get; set; }
    }
}