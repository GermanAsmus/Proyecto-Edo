using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;

namespace Tests
{
    [TestClass]
    public class MensajeTDD
    {
        private static IMensajeDAO mensajeTDD;
        private static CreadorMensaje creador;

        [TestInitialize]
        public void Initialize()
        {
            mensajeTDD = null;
        }
        [TestMethod]
        public void ObtenerMensajeExterno()
        {
            creador = new MensajeExternoCreador("completo");
            mensajeTDD = creador.ObtenerEntidad();
            Assert.IsNotNull(mensajeTDD);
        }
        [TestMethod]
        public void ObtenerMensajeUsuario()
        {
            creador = new MensajeUsuarioCreador("completo");
            mensajeTDD = creador.ObtenerEntidad();
            Assert.IsNotNull(mensajeTDD);
        }
    }
}
