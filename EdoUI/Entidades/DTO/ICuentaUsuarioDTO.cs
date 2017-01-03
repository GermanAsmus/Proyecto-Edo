using System.Collections.Generic;

namespace EdoUI.Entidades.DTO
{
    public interface ICuentaUsuarioDTO : ICuentaDTO
    {
        string Contraseña { get; set; }

        string Nombre { get; set; }

    }
}