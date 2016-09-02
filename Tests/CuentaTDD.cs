using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaInterfaces.Modelo;
using Modelo;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class CuentaTDD
    {
        private static ICuentaDAO cuentaTdd;
        private static string direccion;
        private static CreadorCuenta creador;
        private static ICollection<IMensajeDTO> mensajes;


        [TestInitialize]
        public void Initialize()
        {
            direccion = "tdd@gmail.com";
            mensajes = new List<IMensajeDTO>();
        }

        [TestMethod]
        public void ObtenerCuenaExterna()
        {
            mensajes.Add(new MensajeExternoIncompletoDTO() { Asunto = "TDD" });
            mensajes.Add(new MensajeExternoCompletoDTO() { Asunto = "TDD" , Contenido = "Mensaje externo"});

            creador = new CreadorCuentaExterna(direccion, mensajes);
            cuentaTdd = creador.ObtenerEntidad();
            Assert.IsNotNull(cuentaTdd);
        }
        [TestMethod]
        public void ObtenerCuentaUsuario()
        {
            mensajes.Add(new MensajeUsuarioDTO() { Asunto = "TDD", Contenido = "Mensaje usuario" });
            string nombre, contraseña;
            nombre = nameof(cuentaTdd);
            contraseña = "1234";
            creador = new CreadorCuentaUsuario(direccion, contraseña, nombre, mensajes);
            cuentaTdd = creador.ObtenerEntidad();
            Assert.IsNotNull(cuentaTdd);
        }
    }
}
