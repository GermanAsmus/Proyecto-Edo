using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;

namespace Dominio
{
    /// <summary>
    /// Entidad DireccionCorreo, modela una dirección de correo. Ej: miCorreo@correo.com
    /// </summary>
    public class DireccionCorreo : IDireccionCorreo
    {

        #region Propiedades
        //Identificador único de la direccion de correo.
        public byte Id { get; set; }
        //Direccion de correo real de la entidad. Ej: miCorreo@correo.com
        public string DireccionDeCorreo { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo destinatario.
        public virtual ICollection<Mensaje> MensajesDestinatario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo remitente.
        public virtual ICollection<Mensaje> MensajesRemitente { get; set; }

        public byte CuentaDeUsuarioId { get; set; }

        public ICuentaDeUsuarioDTO CuentaDeUsuario { get; set; }
        #endregion

        public DireccionCorreo(string pDireccionDeCorreo)
        {
            if (string.IsNullOrEmpty(pDireccionDeCorreo))
                throw new ArgumentNullException(string.Format("El parámetro {0} no puede ser nula", nameof(pDireccionDeCorreo)));
            try
            {
                MailAddress auxiliar = new MailAddress(pDireccionDeCorreo);
                this.DireccionDeCorreo = pDireccionDeCorreo;
            }
            catch (FormatException ex)
            {
                throw new FormatException("El formato de la direccion de correo no es valida", ex);
            }

            MensajesRemitente = new List<Mensaje>();
            MensajesDestinatario = new List<Mensaje>();
        }

        public static string ObtenerHost(IDireccionCorreo pDireccion)
        {
            return new MailAddress(pDireccion.DireccionDeCorreo).Host.Split('.')[0];
        }

    }
}
