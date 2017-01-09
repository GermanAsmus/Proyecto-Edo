using EdoUI.Entidades.DTO;
using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Servidor : IServidor
    {
        //Tipo del servidor.
        public string Nombre { get; set; }

        //Protocolos de comunicacion del servidor
        public ICollection<IProtocolo> Protocolos { get; set; }

        public Servidor()
        {
            this.Protocolos = new List<IProtocolo>();
        }

        /// <summary>
        /// Devuelve el servidor correspondiente al servicio gmail o yahoo,
        /// si el host corresponde a alguno de estos valores.
        /// </summary>
        /// <param name="pNombreHost"></param>
        /// <returns>El servidor correspondiente al host, o NullReferenceException</returns>
        public static IServidor ObtenerServidor(string pNombreHost)
        {
            switch (pNombreHost)
            {
                case "gmail": return CrearServidorGmail();
                case "yahoo": return CrearServidorYahoo();
                default: throw new NullReferenceException(pNombreHost);
            }
        }

        private static IServidor CrearServidorGmail()
        {
            IServidor servidor = new Servidor
            {
                Nombre = "gmail"
            };
            servidor.Protocolos.Add(AgregarProtocolo("smtp", "smtp.gmail.com", 587, true));
            servidor.Protocolos.Add(AgregarProtocolo("pop3", "pop.gmail.com", 995, true));

            return servidor;

        }

        private static IServidor CrearServidorYahoo()
        {
            IServidor servidor = new Servidor
            {
                Nombre = "yahoo"
            };
            servidor.Protocolos.Add(AgregarProtocolo("smtp", "smtp.mail.yahoo.com", 587, true));
            servidor.Protocolos.Add(AgregarProtocolo("pop3", "pop.mail.yahoo.com", 995, true));

            return servidor;
        }

        private static IProtocolo AgregarProtocolo(string pTipoProtocolo, string pHost, int pPuerto, bool pSSL)
        {
            return new Protocolo()
            {
                Tipo = pTipoProtocolo,
                Host = pHost,
                Puerto = pPuerto,
                SSL = pSSL
            };
        }


    }
}
