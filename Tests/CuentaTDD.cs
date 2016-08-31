using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;

namespace Tests
{
    [TestClass]
    public class CuentaTDD
    {
        private static ICuentaDTO cuentaTdd;
        private static string direccionCuenta;
        private static CreadorCuenta creador;

        [TestInitialize]
        public void Initialize()
        {
           direccionCuenta = "tdd@gmail.com";
        }

        [TestMethod]
        public void ObtenerCuenaExterna()
        {
            creador = new CreadorCuentaExterna();
            cuentaTdd = creador.ObtenerCuenta(direccionCuenta);
            Assert.IsNotNull(cuentaTdd);
        }
        [TestMethod]
        public void ObtenerCuentaUsuario()
        {
            creador = new CreadorCuentaUsuario();
            cuentaTdd = creador.ObtenerCuenta(direccionCuenta);
            Assert.IsNotNull(cuentaTdd);
        }
    }
}
