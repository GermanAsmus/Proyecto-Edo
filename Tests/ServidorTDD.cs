using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;

namespace Tests
{
    [TestClass]
    public class ServidorTDD
    {
        private static IServidor servidor;
        private static CreadorServidor creador;
        [TestInitialize]
        public void Initialize()
        {
            servidor = null;
        }
        [TestMethod]
        public void ObtenerServidorGmail()
        {
            creador = new CreadorServidorGmail();
            servidor = creador.ObtenerServidor();
            Assert.IsNotNull(servidor);
        }
        [TestMethod]
        public void ObtenerServidorYahoo()
        {
            creador = new CreadorServidorYahoo();
            servidor = creador.ObtenerServidor();
            Assert.IsNotNull(servidor);
        }
    }
}
