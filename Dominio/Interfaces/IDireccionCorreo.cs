using System.Collections.Generic;

namespace Dominio
{
    public interface IDireccionCorreo : IEntidadModelo
    {
        //Direccion de correo real de la entidad. Ej: miCorreo@correo.com
        string DireccionDeCorreo { get; set; }
        //Identificador de la cuenta a la que está asociada la dirección de correo.
        byte CuentaDeUsuarioId { get; set; }
        //Entidad Cuenta a la que está asociada la dirección de correo.
        ICuentaDeUsuarioDTO CuentaDeUsuario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo destinatario.
        ICollection<Mensaje> MensajesDestinatario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo remitente.
        ICollection<Mensaje> MensajesRemitente { get; set; }


    }
}