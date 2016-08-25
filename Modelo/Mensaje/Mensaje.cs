using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;

namespace Modelo
{
    /// <summary>
    /// Entidad Mensaje, modela un menaje o correo.
    /// </summary>
    public class Mensaje : IMensaje
    {
        //Identificador único del mensaje
        public int Id { get; set; }
        //Asunto del mensaje.
        public string Asunto { get; set; }
        //Identificador de la cuenta asociada.
        public int CuentaId { get; set; }
        //Entidad de la cuenta asociada.
        public ICuenta Cuenta { get; set; }    
        // Colección de direcciones de correo como direcciones destinatarios.
        public virtual ICollection<IDireccionCorreo> Destinatario { get; set; }

        public Mensaje()
        {
            Destinatario = new List<IDireccionCorreo>();
        }



        ////Identificador de la dirección de correo asociada al mensaje, como dirección remitente.
        //public int DireccionId { get; set; }
        ////Entidad de la dirección de correo remitente.
        //public DireccionCorreo DireccionCorreo { get; set; }
    }
}
