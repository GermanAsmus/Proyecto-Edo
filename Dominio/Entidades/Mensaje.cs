using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades.Interfaces;

namespace Dominio.Entidades
{
    public class Mensaje : IMensaje, IEstadoMensaje
    {
        /// <summary>
        /// Devuelve el tipo de mensaje según su estructura
        /// </summary>
        /// <param name="pMensaje"></param>
        /// <returns></returns>
        public static string TipoMensaje(Mensaje pMensaje)
        {
            return (string.IsNullOrEmpty(pMensaje.Contenido) && pMensaje.Adjuntos == null) ? "incompleto" : "completo";
        }

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
        public virtual ICollection<IAdjunto> Adjuntos { get; set; }

        #endregion


        private DateTime iEstadoGuardado;
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
            this.Adjuntos = new List<IAdjunto>();
            this.Destinatario = new List<ICuenta>();
        }
    }
}
