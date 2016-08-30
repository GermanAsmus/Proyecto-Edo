using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;

namespace Tests
{
    [TestClass]
    public class CuentaTDD
    {
        private static ICuenta cuentaTdd;
        private static CreadorCuenta creador;
        private static string direccionCuenta;

        [TestInitialize]
        public void Initialize()
        {
            direccionCuenta = "tdd@tdd.com";
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
            //poner como parametro la direccion de correo
            cuentaTdd = creador.ObtenerCuenta(direccionCuenta);
            Assert.IsNotNull(cuentaTdd);
        }
    }
}
