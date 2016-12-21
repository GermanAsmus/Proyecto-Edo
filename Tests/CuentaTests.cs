using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using System.Collections.Generic;
using EdoUI.DTO;
using Persistencia.Entidades.Cuenta;
using Dominio.Entidades.DAO;

namespace Tests
{
    [TestClass]
    public class CuentaTests
    {
        private static ICuentaDAO iCuenta;
        private static string direccion;
        private static CreadorCuenta creador;

        [TestInitialize]
        public void Initialize()
        {
            direccion = "test@gmail.com";
            
        }

        [TestMethod]
        public void ObtenerCuenaExterna()
        {
            ICollection<IMensajeDTO> mensajes = new List<IMensajeDTO>();
            mensajes.Add(new MensajeDTO { Asunto = "test" });
            mensajes.Add(new MensajeDTO { Asunto = "test" , Contenido = "Mensaje externo"});

            creador = new CreadorCuenta();
            iCuenta = creador.CrearCuenta(direccion, mensajes);
            Assert.AreEqual("test@gmail.com", iCuenta.Cuenta.DireccionCorreo.DireccionDeCorreo);
            Assert.AreEqual(2, iCuenta.Cuenta.Mensajes.Count);
        }
        [TestMethod]
        public void ObtenerCuentaUsuario()
        {
            ICollection<IMensajeCompletoDTO> mensajes = new List<IMensajeCompletoDTO>();
            mensajes.Add(new MensajeDTO() { Asunto = "test", Contenido = "Mensaje usuario" });
            string nombre, contraseña;
            nombre = nameof(iCuenta);
            contraseña = "1234";
            creador = new CreadorCuenta();
            iCuenta = creador.CrearCuenta(direccion, contraseña, nombre, mensajes);
            Assert.AreEqual("test@gmail.com", iCuenta.Cuenta.DireccionCorreo.DireccionDeCorreo);
            Assert.AreEqual("iCuenta", (iCuenta.Cuenta as ICuentaUsuarioDTO).Nombre);
            Assert.AreEqual("1234", (iCuenta.Cuenta as ICuentaUsuarioDTO).Contraseña);
        }
    }
}
