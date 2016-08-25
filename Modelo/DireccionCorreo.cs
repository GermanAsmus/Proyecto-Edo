using CapaInterfaces.Modelo;
using CapaInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;

namespace Modelo
{
    /// <summary>
    /// Entidad DireccionCorreo, modela una dirección de correo. Ej: miCorreo@correo.com
    /// </summary>
    public class DireccionCorreo : IDireccionCorreo
    {
        //Identificador único de la direccion de correo.
        public int Id { get; set; }
        //Direccion de correo real de la entidad. Ej: miCorreo@correo.com
        public string DireccionDeCorreo
        {
            get { return this.DireccionDeCorreo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    try
                    {
                        MailAddress auxiliar = new MailAddress(value);
                        this.DireccionDeCorreo = value;
                    }
                    catch (FormatException ex)
                    {
                        throw new FormatException("El formato de la direccion de correo no es valida", ex);
                    }
            }
        }
        //Identificador de la cuenta a la que está asociada la dirección de correo.
        public int CuentaId { get; set; }
        //Entidad Cuenta a la que está asociada la dirección de correo.
        public ICuenta Cuenta { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo destinatario.
        public virtual ICollection<IMensaje> MensajesDestinatario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo remitente.
        public virtual ICollection<IMensaje> MensajesRemitente { get; set; }

        public DireccionCorreo()
        {
            MensajesRemitente = new List<IMensaje>();
            MensajesDestinatario = new List<IMensaje>();
        }
    }
}
