using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;

namespace Tests
{
    [TestClass]
    public class ServidorTests
    {
        private static IServidorDAO servidor;
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
            Assert.AreEqual(servidor.Obtener(p => p.Tipo == "smtp").Host, "smtp.gmail.com");
            Assert.AreEqual(servidor.Obtener(p => p.Tipo == "pop").Host, "pop.gmail.com");
        }
        [TestMethod]
        public void ObtenerServidorYahoo()
        {
            servidor = creador.CrearServidorYahoo();
            Assert.AreEqual(servidor.Obtener(p => p.Tipo == "smtp").Host, "smtp.mail.yahoo.com");
            Assert.AreEqual(servidor.Obtener(p => p.Tipo == "pop").Host, "pop.mail.yahoo.com");
        }
    }
}
