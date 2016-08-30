using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface ICuentaUsuario : ICuenta
    {
        string Contraseña { get; set; }
        //ICollection<IMensaje> Mensajes { get; set; }
        string Nombre { get; set; }

    }
}