using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Modelo
{
    public class CuentaUsuario : Cuenta, ICuentaUsuario
    {
        //Nombre de la cuenta.
        public string Nombre { get; set; }
        //Contraseña de la cuenta
        public string Contraseña { get; set; }

        public IServidor Servidor { get; set; }
        //Entidad de la direccion de correo a la que está relacionada la cuenta.

        //Colección de mensjes que mantiene la cuenta.
        public virtual ICollection<IMensaje> Mensajes { get; set; }

        public CuentaUsuario()
        {
            Mensajes = new List<IMensaje>();
        }

        public string ReconocerServidor(IDireccionCorreo pDireccion)
        {
            return new MailAddress(pDireccion.DireccionDeCorreo).Host;
        }

        public IMensaje RedactarNuevoMensaje(string pCuerpoMensaje, string pAsuntoMensaje, IList<string> pDireccionesCorreo)
        {
            //preguntar cómo se puede hacer llamando al repositorio de mensajes, que ya tiene el codigo para agregar
            Mensaje nuevoMensaje = new MensajeCompleto(this);
            //{
            //    Contenido = pCuerpoMensaje,
            //    Asunto = pAsuntoMensaje,
            //    Fecha = DateTime.Today.ToShortDateString(),
            //    CuentaId = this.Id
            //};
            foreach (string direccion in pDireccionesCorreo)
            {
                nuevoMensaje.Destinatario.Add(new DireccionCorreo() { DireccionDeCorreo = direccion });
            }
            return nuevoMensaje;
        }
    }
}
