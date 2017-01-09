using EdoUI.Entidades.DTO;

namespace Dominio.Entidades
{
    public class CuentaUsuario : Cuenta, ICuentaUsuario
    {
        public string Contraseña { get; set; }

        public string Nombre { get; set; }
    }
}