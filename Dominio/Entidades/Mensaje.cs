using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Dominio
{
    public class Mensaje : IMensajeDTO
    {
        #region Atributos

        public byte Id { get; set; }

        public string Asunto { get; set; }

        public DireccionCorreo Remitente { get; set; }

        public byte RemitenteId { get; set; }

        public ICollection<DireccionCorreo> Destinatario { get; set; }

        public string Contenido { get; set; }

        #endregion

        /// <summary>
        /// Constructor de la clase, se inicializan las listas de adjuntos y los destinatarios
        /// </summary>
        public Mensaje()
        {
            this.Destinatario = new List<DireccionCorreo>();
            this.Contenido = string.Empty;
        }
        public Mensaje(MailMessage pMailMessage)
        {
            if (pMailMessage == null)
                throw new ArgumentNullException(nameof(pMailMessage));

            this.Destinatario = new List<DireccionCorreo>();

            this.Asunto = pMailMessage.Subject;
            this.Remitente = new DireccionCorreo(pMailMessage.From.Address);
            this.Contenido = pMailMessage.Body;

            pMailMessage.To.ToList().ForEach(x => this.Destinatario.Add(new DireccionCorreo(x.Address)));
        }
    }
}
