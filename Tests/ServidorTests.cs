using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia.Entidades.Servidor;
using EdoUI.DTO;
using System.Linq;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class ServidorTests
    {
        private static IServidorDTO servidor;
        private static CreadorServidor creador;
        [TestInitialize]
        public void Initialize()
        {
            servidor = null;
            creador = new CreadorServidor();
        }
        [TestMethod]
        public void ObtenerServidorGmail()
        {
            servidor = creador.CrearServidorGmail();

            Assert.IsTrue(servidor.Protocolos.ToList()[0].Tipo == "smtp");
            Assert.IsTrue(servidor.Protocolos.ToList()[0].Host == "smtp.gmail.com");

            Assert.IsTrue(servidor.Protocolos.ToList()[1].Tipo == "pop3");
            Assert.IsTrue(servidor.Protocolos.ToList()[1].Host == "pop.gmail.com");
           
        }
        [TestMethod]
        public void ObtenerServidorYahoo()
        {
            servidor = creador.CrearServidorYahoo();

            Assert.IsTrue(servidor.Protocolos.ToList()[0].Tipo == "smtp");
            Assert.IsTrue(servidor.Protocolos.ToList()[0].Host == "smtp.mail.yahoo.com");

            Assert.IsTrue(servidor.Protocolos.ToList()[1].Tipo == "pop3");
            Assert.IsTrue(servidor.Protocolos.ToList()[1].Host == "pop.mail.yahoo.com");

        }
    }
}
