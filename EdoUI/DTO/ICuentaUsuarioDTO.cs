using System.Collections.Generic;

namespace EdoUI.DTO
{
    public interface ICuentaUsuarioDTO : ICuentaDTO
    {
        string Contraseña { get; set; }

        string Nombre { get; set; }

    }
}