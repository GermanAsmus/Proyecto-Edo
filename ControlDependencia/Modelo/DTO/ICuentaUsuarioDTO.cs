using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface ICuentaUsuarioDTO : ICuentaDTO
    {
        string Contraseña { get; set; }

        string Nombre { get; set; }

    }
}