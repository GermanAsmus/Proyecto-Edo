using EdoUI.Entidades.DTO;
using System;
using System.Collections.Generic;

namespace Dominio.Entidades.DTO
{
    public class ServidorDTO : IServidorDTO
    {
        //Tipo del servidor.
        public string Nombre { get; set; }

        //Protocolos de comunicacion del servidor
        public ICollection<IProtocoloDTO> Protocolos { get; set; }

        public ServidorDTO()
        {
            this.Protocolos = new List<IProtocoloDTO>();
        }

        /// <summary>
        /// Devuelve el servidor correspondiente al servicio gmail o yahoo,
        /// si el host corresponde a alguno de estos valores.
        /// </summary>
        /// <param name="pNombreHost"></param>
        /// <returns>El servidor correspondiente al host, o NullReferenceException</returns>
        public static IServidorDTO ObtenerServidor(string pNombreHost)
        {
            switch (pNombreHost)
            {
                case "gmail": return CrearServidorGmail();
                case "yahoo": return CrearServidorYahoo();
                default: throw new NullReferenceException(pNombreHost);
            }
        }

        private static IServidorDTO CrearServidorGmail()
        {
            IServidorDTO servidor = new ServidorDTO
            {
                Nombre = "gmail"
            };
            servidor.Protocolos.Add(AgregarProtocolo("smtp", "smtp.gmail.com", 587, true));
            servidor.Protocolos.Add(AgregarProtocolo("pop3", "pop.gmail.com", 995, true));

            return servidor;

        }

        private static IServidorDTO CrearServidorYahoo()
        {
            IServidorDTO servidor = new ServidorDTO
            {
                Nombre = "yahoo"
            };
            servidor.Protocolos.Add(AgregarProtocolo("smtp", "smtp.mail.yahoo.com", 587, true));
            servidor.Protocolos.Add(AgregarProtocolo("pop3", "pop.mail.yahoo.com", 995, true));

            return servidor;
        }

        private static IProtocoloDTO AgregarProtocolo(string pTipoProtocolo, string pHost, int pPuerto, bool pSSL)
        {
            return new ProtocoloDTO()
            {
                Tipo = pTipoProtocolo,
                Host = pHost,
                Puerto = pPuerto,
                SSL = pSSL
            };
        }


    }
}
