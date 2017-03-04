using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Helper
{
    /// <summary>
    /// Esta clase facilita la creación de un servidor.
    /// </summary>
    public static class CreadorServidor
    {
        public static IServidor CrearServidorGmail()
        {
            IServidor servidor = new Servidor
            {
                Nombre = "gmail"
            };
            servidor.Protocolos.Add(new Smtp() {
                Tipo = TipoProtocolo.smtp,
                Host = "smtp.gmail.com",
                Puerto = 587,
                SSL = true
            });//AgregarProtocolo("smtp", "smtp.gmail.com", 587, true) as Smtp);
            servidor.Protocolos.Add(new Pop3{
                Tipo = TipoProtocolo.pop3,
                Host = "pop.gmail.com",
                Puerto = 995,
                SSL = true
            });//AgregarProtocolo("pop3", "pop.gmail.com", 995, true) as Pop3);

            return servidor;

        }

        public static IServidor CrearServidorYahoo()
        {
            IServidor servidor = new Servidor
            {
                Nombre = "yahoo"
            };
            servidor.Protocolos.Add(new Smtp() {
                Tipo = TipoProtocolo.smtp,
                Host = "smtp.mail.yahoo.com",
                Puerto = 587,
                SSL = true
            });//AgregarProtocolo("smtp", "smtp.mail.yahoo.com", 587, true));
            servidor.Protocolos.Add(new Pop3() {
                Tipo = TipoProtocolo.pop3,
                Host = "pop.mail.yahoo.com",
                Puerto = 995,
                SSL = true
            });//AgregarProtocolo("pop3", "pop.mail.yahoo.com", 995, true));

            return servidor;
        }

        public static IServidor CrearServidorExterno(string pNombre)
        {

            IServidor servidor = new Servidor
            {
                Nombre = pNombre
            };
            return servidor;
        }

        /// <summary>
        /// Devuelve el servidor correspondiente al servicio gmail o yahoo,
        /// si el host corresponde a alguno de estos valores.
        /// </summary>
        /// <param name="pNombreHost"></param>
        /// <returns>El servidor correspondiente al host, o NullReferenceException</returns>
        public static IServidor CrearServidor(string pNombreHost)
        {
            switch (pNombreHost)
            {
                case "gmail": return CrearServidorGmail();
                case "yahoo": return CrearServidorYahoo();
                default: return CrearServidorExterno(pNombreHost);
            }
        }
    }
}
