using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilidades;
using Utilidades.Internet;

namespace UnitTestEdo
{
    [TestClass]
    public class VerificarConexionTest
    {
        [TestMethod]
        public void VerificarLaConexion()
        {
            Assert.IsTrue(VerificarConexion.ObtenerEstadoConexion());
        }

    }
}
