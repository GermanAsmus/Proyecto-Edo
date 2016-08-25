using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;

namespace Tests.Modelo
{
    /// <summary>
    /// Summary description for CuentaTest
    /// </summary>
    [TestClass]
    public class CuentaTest
    {
        private static Cuenta iCuenta;

        public CuentaTest()
        {
            iCuenta = new Cuenta();
        }

        [TestMethod]
        public void RedactarNuevoMensaje()
        {
            int cantidadMensajes = iCuenta.Mensajes.Count;

            string pCuerpoMensaje = "Haciendo Testing";
            string pAsuntoMensaje = "Testing";
            IList<string> pDireccionesCorreo = new List<string>() { "correo@correo.com" };

            var mensaje = iCuenta.RedactarNuevoMensaje(pCuerpoMensaje,pAsuntoMensaje,pDireccionesCorreo);
            Assert.IsNotNull(mensaje);
            Assert.AreEqual(cantidadMensajes, iCuenta.Mensajes.Count);
        }
        [TestMethod]
        public void EnviarNuevoMensje()
        {

        }
    }
}
