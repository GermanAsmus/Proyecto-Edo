using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CuentaUsuarioDTO : CuentaDTO, ICuentaUsuarioDTO
    {
        public string Contraseña { get; set; }

        public string Nombre { get; set; }
    }
}