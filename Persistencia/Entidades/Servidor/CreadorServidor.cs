﻿using System;
using EdoUI.DTO;
using Dominio.Entidades.DAO;
using System.Collections.Generic;

namespace Persistencia.Entidades.Servidor
{
    public class CreadorServidor
    {

        public IServidorDTO ObtenerServidor(string pNombreHost)
        {
            switch (pNombreHost)
            {
                case "gmail": return CrearServidorGmail();
                case "yahoo": return CrearServidorYahoo();
                default: throw new NullReferenceException(pNombreHost);
            }
        }

        public IServidorDTO CrearServidorGmail()
        {
            IServidorDTO servidor = new ServidorDTO
            {
                Nombre = "gmail"
            };
            servidor.Protocolos.Add(this.AgregarProtocolo("smtp", "smtp.gmail.com", 587, true));
            servidor.Protocolos.Add(this.AgregarProtocolo("pop3", "pop.gmail.com", 995, true));

            return servidor;
        }

        public IServidorDTO CrearServidorYahoo()
        {
            IServidorDTO servidor = new ServidorDTO
            {
                Nombre = "yahoo"
            };
            servidor.Protocolos.Add(this.AgregarProtocolo("smtp", "smtp.mail.yahoo.com", 587, true));
            servidor.Protocolos.Add(this.AgregarProtocolo("pop3", "pop.mail.yahoo.com", 995, true));

            return servidor;
        }

        private IProtocoloDTO AgregarProtocolo(string pTipoProtocolo, string pHost, int pPuerto, bool pSSL)
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