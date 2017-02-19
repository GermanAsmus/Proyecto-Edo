using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades.Interfaces;
using System.Net.Mail;

namespace Dominio.Entidades
{
    public class Mensaje : IMensaje, IEstadoMensaje
    {
        #region Metodos estáticos
        /// <summary>
        /// Devuelve el tipo de mensaje según su estructura
        /// </summary>
        /// <param name="pMensaje"></param>
        /// <returns></returns>
        public static string TipoMensaje(Mensaje pMensaje)
        {
            return (string.IsNullOrEmpty(pMensaje.Contenido)/* && pMensaje.Adjuntos == null*/) ? "incompleto" : "completo";
        }
        #endregion

        #region Atributos Mensaje Estandar

        //Identificador único del mensaje
        public int Id { get; set; }
        //Asunto del mensaje.
        public string Asunto { get; set; }
        //Identificador de la cuenta asociada.
        public int CuentaId { get; set; }
        //Entidad de la cuenta asociada.
        public ICuenta Cuenta { get; set; }
        // Colección de direcciones de correo como direcciones destinatarios.
        public virtual ICollection<ICuenta> Destinatario { get; set; }

        #endregion

        #region Atributos Mensaje Completo

        // Contenido en Texto Plano
        public string Contenido { get; set; }

        // Coleccion de adjuntos del mensaje.
       // public virtual ICollection<IAdjunto> Adjuntos { get; set; }

        #endregion


        private DateTime iEstadoGuardado;
        /// <summary>
        /// Fecha del estado de guardado
        /// </summary>
        public string EstadoGuardado
        {
            get
            {
                if (iEstadoGuardado != null)
                    return string.Concat("Mensaje guardado: ",iEstadoGuardado.ToShortDateString());
                else
                    return "Mensaje no guardado";
            }

            set
            {
                if (!DateTime.TryParse(value, out this.iEstadoGuardado))
                    throw new FormatException("El formato de la fecha ingresada no es válida");
            }
        }

        private DateTime iEstadoEnviado;
        /// <summary>
        /// Fecha del estado de enviado
        /// </summary>
        public string EstadoEnviado
        {
            get
            {
                if (iEstadoEnviado != null)
                    return string.Concat("Mensaje enviado: ", iEstadoEnviado.ToShortDateString());
                else
                    return "Mensaje no enviado";
            }

            set
            {
                if (!DateTime.TryParse(value, out this.iEstadoEnviado))
                    throw new FormatException("El formato de la fecha ingresada no es válida");
            }
        }

        private DateTime iEstadoVisto;
        /// <summary>
        /// Fecha del estado de visto
        /// </summary>
        public string EstadoVisto
        {
            get
            {
                if (iEstadoVisto != null)
                    return string.Concat("Mensaje visto: ", iEstadoVisto.ToShortDateString());
                else
                    return "Mensaje no visto";
            }

            set
            {
                if (!DateTime.TryParse(value, out this.iEstadoVisto))
                    throw new FormatException("El formato de la fecha ingresada no es válida");
            }
        }

        /// <summary>
        /// Constructor de la clase, se inicializan las listas de adjuntos y los destinatarios
        /// </summary>
        public Mensaje()
        {
            this.Destinatario = new List<ICuenta>();
        }
        public Mensaje(MailMessage pMailMessage)
        {
            this.Destinatario = new List<ICuenta>();

            if (pMailMessage == null)
                throw new ArgumentNullException(nameof(pMailMessage));

            this.EstadoGuardado = DateTime.Today.ToShortDateString();
            this.Asunto = pMailMessage.Subject;
            this.Cuenta = new Cuenta(pMailMessage.From.Address);
               

            if(!string.IsNullOrEmpty(pMailMessage.Body))
                this.Contenido = pMailMessage.Body;

            pMailMessage.To.ToList().ForEach(x => this.Destinatario.Add(new Cuenta(x.Address)));
        }
    }
}
