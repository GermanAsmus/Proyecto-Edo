using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IDireccionCorreoDTO : IEntidadModelo
    {
        //Direccion de correo real de la entidad. Ej: miCorreo@correo.com
        string DireccionDeCorreo { get; set; }
        //Identificador de la cuenta a la que está asociada la dirección de correo.
        int CuentaId { get; set; }
        //Entidad Cuenta a la que está asociada la dirección de correo.
        ICuentaDTO Cuenta { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo destinatario.
        ICollection<IMensajeDTO> MensajesDestinatario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo remitente.
        ICollection<IMensajeDTO> MensajesRemitente { get; set; }


    }
}