using System.Collections.Generic;

namespace Dominio.Entidades.Interfaces
{
    public interface IDireccionCorreo : IEntidadModelo
    {
        //Direccion de correo real de la entidad. Ej: miCorreo@correo.com
        string DireccionDeCorreo { get; set; }
        //Identificador de la cuenta a la que está asociada la dirección de correo.
        int CuentaId { get; set; }
        //Entidad Cuenta a la que está asociada la dirección de correo.
        ICuenta Cuenta { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo destinatario.
        ICollection<IMensaje> MensajesDestinatario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo remitente.
        ICollection<IMensaje> MensajesRemitente { get; set; }


    }
}