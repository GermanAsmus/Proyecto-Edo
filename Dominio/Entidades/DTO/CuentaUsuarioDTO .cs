using EdoUI.Entidades.DTO;

namespace Dominio.Entidades.DTO
{
    public class CuentaUsuarioDTO : CuentaDTO, ICuentaUsuarioDTO
    {
        public string Contraseña { get; set; }

        public string Nombre { get; set; }
    }
}