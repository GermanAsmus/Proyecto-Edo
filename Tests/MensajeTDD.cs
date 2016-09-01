using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;

namespace Tests
{
    [TestClass]
    public class MensajeTDD
    {
        private static IMensajeDTO mensajeTDD;
        private static CreadorMensaje creador;

        [TestInitialize]
        public void Initialize()
        {
            
        }
        [TestMethod]
        public void ObtenerMensajeExterno()
        {
            creador = new MensajeExternoCreador();
            mensajeTDD = creador.ObtenerMensaje();
            Assert.IsNotNull(mensajeTDD);
        }
        [TestMethod]
        public void ObtenerMensajeUsuario()
        {
            creador = new MensajeUsuarioCreador();
            mensajeTDD = creador.ObtenerMensaje();
            Assert.IsNotNull(mensajeTDD);
        }
    }
}
