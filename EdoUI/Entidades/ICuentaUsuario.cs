using System.Collections.Generic;

namespace EdoUI.Entidades.DTO
{
    public interface ICuentaUsuario : ICuenta
    {
        string Contraseña { get; set; }

        string Nombre { get; set; }

    }
}