using CapaInterfaces;
using EdoUI.Entidades.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;

namespace Dominio.Entidades.DTO
{
    /// <summary>
    /// Entidad DireccionCorreo, modela una dirección de correo. Ej: miCorreo@correo.com
    /// </summary>
    public class DireccionCorreoDTO : IDireccionCorreoDTO
    {

        #region Propiedades
        //Identificador único de la direccion de correo.
        public int Id { get; set; }
        //Direccion de correo real de la entidad. Ej: miCorreo@correo.com
        public string DireccionDeCorreo { get; set; }
        //Identificador de la cuenta a la que está asociada la dirección de correo.
        public int CuentaId { get; set; }
        //Entidad CuentaDAO a la que está asociada la dirección de correo.
        public ICuentaDTO Cuenta { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo destinatario.
        public virtual ICollection<IMensajeDTO> MensajesDestinatario { get; set; }
        //Colección de mensajes en los que la dirección de correo está asociada como dirección de correo remitente.
        public virtual ICollection<IMensajeDTO> MensajesRemitente { get; set; }
        #endregion
        
        public DireccionCorreoDTO(string pDireccionDeCorreo)
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

            MensajesRemitente = new List<IMensajeDTO>();
            MensajesDestinatario = new List<IMensajeDTO>();
        }

        public static string ObtenerHost(IDireccionCorreoDTO pDireccion)
        {
            return new MailAddress(pDireccion.DireccionDeCorreo).Host.Split('.')[0];
        }
    }
}
