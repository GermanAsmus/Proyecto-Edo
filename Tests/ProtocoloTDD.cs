using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;

namespace Tests
{
    [TestClass]
    public class ProtocoloTDD
    {
        private static IProtocoloDTO protocolo;
        private static CreadorProtocolo creador;

        [TestInitialize]
        public void Initialize()
        {
            protocolo = null;

        }
        [TestMethod]
        public void ObtenerProtocoloPOP()
        {
            creador = new CreadorProtocoloPOP();
            protocolo = creador.ObtenerEntidad();
            Assert.IsNotNull(protocolo);
        }
        [TestMethod]
        public void ObtenerProtocoloSMTP()
        {
            creador = new CreadorProtocoloSMTP();
            protocolo = creador.ObtenerEntidad();
            Assert.IsNotNull(protocolo);
        }
    }
}
