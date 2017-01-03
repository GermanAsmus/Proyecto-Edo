using System;

namespace EdoUI.Entidades
{
    public interface IEstadoMensaje
    {
        string EstadoGuardado { get; set; }
        string EstadoEnviado { get; set; }
        string EstadoVisto { get; set; }
    }
}