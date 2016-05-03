using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Modelo;

namespace Persistencia.Tests
{
    [TestClass()]
    public class RepositorioTestsRepositorio
    {
    //    static EntityFrameworkDBContext unitContext = new EntityFrameworkDBContext();

    //    static Repositorio<DireccionCorreo> repoDireccionCorreo = new Repositorio<DireccionCorreo>(unitContext);
    //    static Repositorio<Servidor> repoServidor = new Repositorio<Servidor>(unitContext);
    //    static Repositorio<Cuenta> repoCuenta = new Repositorio<Cuenta>(unitContext);
    //    static Repositorio<Mensaje> repoMensaje = new Repositorio<Mensaje>(unitContext);
    //    static Repositorio<Adjunto> repoAdjunto = new Repositorio<Adjunto>(unitContext);

    //    static DireccionCorreo unaDireccion = new DireccionCorreo() { DireccionId = "unitTest@testing.com" };
    //    static Servidor unServidor = new Servidor()
    //    {
    //        Nombre = "testing",
    //        HostPOP = "popTest",
    //        HostSMTP = "smtpTest",
    //        PuertoPOP = 25,
    //        PuertoSMTP = 25,
    //        SSL = true
    //    };
    //    //Test: Agregación
    //    [TestMethod()]
    //    public void AgregarTestDireccion()
    //    {
    //        //se agrega mediante el repositorio de DireccionCorreo la entidad unaDireccion
    //        //como el mensaje es asincrónico, el valor de retorno es de tipo Task<int>
    //        //como resultado del mensaje interno saveAsync.
    //        var aTask = repoDireccionCorreo.Agregar(unaDireccion);
    //        Task.WaitAll(aTask);
    //        //el resultado de tipo int, 
    //        //representa el numero de entidades que formaron parte del proceso de guardado
    //        if (aTask.Result > 0)
    //            Assert.IsTrue(true);
    //        else
    //            Assert.Fail();
    //    }
    //    [TestMethod()]
    //    public void AgregarTestServidor()
    //    {
    //        //Se agrega mediante el repositorio de Servidores, la entidad unServidor.
    //        //Como el mensaje es asincrónico, el valor de retorno es de tipo Task<int>
    //        var aTask = repoServidor.Agregar(unServidor);
    //        Task.WaitAll(aTask);
    //        //Si se realizó el proceso de guardado, el valor de retorno debe ser mayor a cero
    //        if (aTask.Result > 0)
    //            Assert.IsTrue(true);
    //        else
    //            Assert.Fail();
    //    }
    //    [TestMethod()]
    //    public void AgregarTestCuenta()
    //    {
    //        //Se crea una nueva entidad del tipo Cuenta
    //        Cuenta unaCuenta = new Cuenta()
    //        {
    //            Contraseña = "contasenia",
    //            CuentaId = "unaCuenta",
    //        };

    //        // Obtención del servidor residente en la base de datos
    //        // El proceso es asincrónico, devuelve un valor del tipo Task<Servidor>

    //        var servidorTask = repoServidor.ObtenerAsync(x => x.Nombre == unServidor.Nombre, CancellationToken.None);
    //        Task.WaitAll(servidorTask);

    //        Servidor dbServidor = null;
    //        if (servidorTask.Result != null)
    //            dbServidor = servidorTask.Result;
    //        else
    //            Assert.Fail();

    //        // Obtencion de la direccion residente en la base de datos
    //        //El proceso es asincronico, devuelve un valor del tipo Task<DireccionCorreo>

    //        var direccionTask = repoDireccionCorreo.ObtenerAsync(x => x.DireccionId == unaDireccion.DireccionId, CancellationToken.None);
    //        Task.WaitAll(direccionTask);

    //        DireccionCorreo dbDireccion = null;
    //        if (direccionTask.Result != null)
    //            dbDireccion = direccionTask.Result;
    //        else
    //            Assert.Fail();

    //        /* 
    //         Para agregar una cuenta a la base de datos, el orden de las instrucciones debe ser siempre el mismo. 
    //         Por qué del orden:
    //             Una entidad del tipo cuenta requiere de todos sus campos,
    //             pero es escencial que se detalle la dirección de correo,
    //             entonces debe especificarse inicialmente la asociacion entre la dirección de correo y la cuenta.
    //             Se deberá incluír en la entidad DirecciónCorreo, la cuenta, y luego el id de la cuenta.
    //             Secuencialmente, en la entidad Cuenta se debrá especificar el id de la direccion de correo.
                 
    //             Una vez satisfecha la relación entre estas dos entidades, queda asociar el servidor con la cuenta.
    //             Declarar el servidor que se relaciona con la cuenta, es tan fundamental como definir la direccion para la cuenta,
    //             eso es porque para la cuenta, el servidor también es una propiedad requerida.
    //             En este caso, el servidor define una colección de cuentas, pues existen muchas cuentas que se refieren a un servidor
    //             (ej: gmail, yahoo, etc.).
    //             Primero se indica con cuál servidor se asociará con la cuenta,
    //             por consiguiente se agregará la cuenta a la coleccion de cuentas en el servidor,
    //             y por último, se define el id del servidor en la cuenta.
    //        */
    //        dbDireccion.Cuenta = unaCuenta;
    //        dbDireccion.CuentaId = unaCuenta.CuentaId;
    //        unaCuenta.DireccionId = dbDireccion.DireccionId;

    //        unaCuenta.Servidor = dbServidor;
    //        dbServidor.Cuenta.Add(unaCuenta);

    //        unaCuenta.ServidorId = dbServidor.Nombre;

    //        // Importante: La cuenta no se agrega a la base de datos como se hace con una direccion de correo o un servidor,
    //        // esto es porque la cuenta es dependiente de estas entidades, la forma de añadir una cuenta a la base de datos
    //        // es actualizando el servidor que contiene en su colección de cuentas, a la nueva cuenta que se creó.
    //        //Se actualiza el servidor que posee la nueva cuenta
    //        var aFirstTask = repoServidor.Editar(dbServidor);
    //        Task.WaitAll(aFirstTask);
    //        //El valor devuelto es un int, que representa qué cantidad de entidades se involucraron en la operación.
    //        if (aFirstTask.Result > 0)
    //        {
    //            //Se verifica que la cuenta existe en la base de datos.
    //            var aSecondTask = repoCuenta.ObtenerAsync(x => x.CuentaId == unaCuenta.CuentaId, CancellationToken.None);
    //            Task.WaitAll(aSecondTask);
    //            if (aSecondTask.Result != null)
    //                Assert.IsTrue(true);
    //        }
    //        else
    //            Assert.Fail();
    //    }
    //    [TestMethod()]
    //    public void AgregarTestMensaje()
    //    {
    //        //Obtención de la cuenta residente en la base de datos
    //        var cuentaTask = repoCuenta.ObtenerAsync(x => x.DireccionId == unaDireccion.DireccionId, CancellationToken.None);
    //        Task.WaitAll(cuentaTask);

    //        Cuenta dbCuenta = null;
    //        if (cuentaTask.Result != null)
    //            dbCuenta = cuentaTask.Result;
    //        else
    //            Assert.Fail();

    //        //Se crea un nuevo mensaje
    //        Mensaje unMensaje = new Completo()
    //        {
    //            MensajeId = "0",
    //            Asunto = "Estaba testeando como un campeon",
    //            Contenido = "Contenido del Test",
    //            Fecha = DateTime.Now.ToLongDateString(),
    //            Destinatario = new List<DireccionCorreo>() { new DireccionCorreo() { DireccionId = "friendOfMine@testing.com" } },
    //            DireccionCorreo = dbCuenta.DireccionCorreo,
    //            Remitente = dbCuenta.DireccionId
    //        };
    //        //Se añade el mensaje a la colección de mensaje de la cuenta
    //        dbCuenta.Mensajes.Add(unMensaje);
    //        //Se completa la propiedad requerida del mensaje, respectiva al id de la cuenta.
    //        unMensaje.CuentaId = dbCuenta.CuentaId;

    //        //Se actualiza la cuenta, que mantiene una colección de mensajes.
    //        var aTask = repoCuenta.Editar(dbCuenta);
    //        Task.WaitAll(aTask);
    //        if (aTask.Result > 0)
    //            Assert.IsTrue(true);
    //        else
    //            Assert.Fail();
    //    }
    //    [TestMethod()]
    //    public void AgregarTestAdjunto()
    //    {
    //        //Se obtiene el mensaje residente en la base de datos
    //        var mensajeTask = repoMensaje.ObtenerAsync(x => x.Remitente == unaDireccion.DireccionId, CancellationToken.None);
    //        Task.WaitAll(mensajeTask);

    //        Mensaje dbMensaje = null;
    //        if (mensajeTask.Result != null)
    //            dbMensaje = mensajeTask.Result;
    //        else
    //            Assert.Fail();
    //        //Se crea una nueva instancia de Adjunto
    //        Adjunto unAdjunto = new Adjunto() { AdjuntoId = @"C:\Users\german\Desktop\seed.txt" };

    //        //Se agrega el adjunto a la colección de adjuntos del mensaje
    //        ((Completo)dbMensaje).Adjuntos.Add(unAdjunto);

    //        //Se actualiza el mensaje
    //        var aTask = repoMensaje.Editar(dbMensaje);
    //        Task.WaitAll(aTask);
    //        if (aTask.Result > 0)
    //            Assert.IsTrue(true);
    //        else
    //            Assert.Fail();
    //    }
    //    //Test: Edición
    //    [TestMethod()]
    //    public void EditarTestServidor()
    //    {
    //        //Se obtiene el servidor residente en la base de datos
    //        var servidorTask = repoServidor.ObtenerAsync(x => x.Nombre == unServidor.Nombre, CancellationToken.None);
    //        Task.WaitAll(servidorTask);

    //        Servidor dbServidor = null;
    //        if (servidorTask.Result != null)
    //            dbServidor = servidorTask.Result;
    //        else
    //            Assert.Fail();

    //        //Se editan las propiedades del servidor
    //        dbServidor.HostPOP = "nuevoHostPop";
    //        dbServidor.SSL = false;
            
    //        //Se actualiza el servidor
    //        var aTask = repoServidor.Editar(dbServidor);
    //        if (aTask.Result > 0)
    //            Assert.IsTrue(true);
    //        else
    //            Assert.Fail();
    //    }
    //    [TestMethod()]
    //    public void EditarTestCuenta()
    //    {
    //        //Se obtiene la cuenta residente en la base de datos
    //        var cuentaTask = repoCuenta.ObtenerAsync(x => x.DireccionId == unaDireccion.DireccionId, CancellationToken.None);
    //        Task.WaitAll(cuentaTask);

    //        Cuenta dbCuenta = null;
    //        if (cuentaTask.Result != null)
    //            dbCuenta = cuentaTask.Result;
    //        else
    //            Assert.Fail();
    //        //Se modifica la propiedad de la cuenta
    //        dbCuenta.Contraseña = "nuevaContrasenia";
    //        //Se actualiza la cuenta
    //        var aTask = repoCuenta.Editar(dbCuenta);
    //        if (aTask.Result > 0)
    //            Assert.IsTrue(true);
    //        else
    //            Assert.Fail();
    //    }
    //    [TestMethod()]
    //    public void EditarTestMensaje()
    //    {
    //        //Se obiene el mensaje residente en la base de datos
    //        var mensajeTask = repoMensaje.ObtenerAsync(x => x.MensajeId == "0", CancellationToken.None);
    //        Task.WaitAll(mensajeTask);

    //        Mensaje dbMensaje = null;
    //        if (mensajeTask.Result != null)
    //            dbMensaje = mensajeTask.Result;
    //        else
    //            Assert.Fail();
    //        //Se modifican las propiedades del mensaje
    //        dbMensaje.Asunto = "Asunto Editado";
    //        ((Completo)dbMensaje).Contenido = "Contenido Editado";
            
    //        //Se actualiza el mensaje
    //        var aTask = repoMensaje.Editar(dbMensaje);
    //        if (aTask.Result > 0)
    //            Assert.IsTrue(true);
    //        else
    //            Assert.Fail();
    //    }
    //    //Test: Eliminación;
    //    [TestMethod()]
    //    public void EliminarTestDireccion()
    //    {
    //        var direccionTask = repoDireccionCorreo.ObtenerAsync(x => x.DireccionId == unaDireccion.DireccionId, CancellationToken.None);
    //        Task.WaitAll(direccionTask);
    //        if (direccionTask.Result == null)
    //            Assert.Fail();
    //        else
    //        {
    //            var aTask = repoDireccionCorreo.Eliminar(direccionTask.Result);
    //            Task.WaitAll(direccionTask);

    //            if (aTask.Result > 0)
    //                Assert.IsTrue(true);
    //            else
    //                Assert.Fail();
    //        }
    //    }
    //    [TestMethod()]
    //    public void EliminarTestServidor()
    //    {
    //        var servidorTask = repoServidor.ObtenerAsync(x => x.Nombre == unServidor.Nombre, CancellationToken.None);
    //        Task.WaitAll(servidorTask);
    //        if (servidorTask.Result == null)
    //            Assert.Fail();
    //        else
    //        {
    //            var aTask = repoServidor.Eliminar(servidorTask.Result);
    //            Task.WaitAll(aTask);

    //            if (aTask.Result > 0)
    //                Assert.IsTrue(true);
    //            else
    //                Assert.Fail();
    //        }
    //    }
    //    [TestMethod()]
    //    public void EliminarTestCuenta()
    //    {
    //        var cuentaTask = repoCuenta.ObtenerAsync(x => x.DireccionId == unaDireccion.DireccionId, CancellationToken.None);
    //        Task.WaitAll(cuentaTask);
    //        if (cuentaTask.Result == null)
    //            Assert.Fail();
    //        else
    //        {
    //            var aTask = repoCuenta.Eliminar(cuentaTask.Result);
    //            Task.WaitAll(aTask);
    //            if (aTask.Result > 0)
    //                Assert.IsTrue(true);
    //            else
    //                Assert.Fail();
    //        }
    //    }
    //    [TestMethod()]
    //    public void EliminarTestMensaje()
    //    {
    //        var mensajeTask = repoMensaje.ObtenerAsync(x => x.MensajeId == "0", CancellationToken.None);
    //        Task.WaitAll(mensajeTask);
    //        if (mensajeTask.Result == null)
    //            Assert.Fail();
    //        else
    //        {
    //            var aTask = repoMensaje.Eliminar(mensajeTask.Result);
    //            Task.WaitAll(aTask);
    //            if (aTask.Result > 0)
    //                Assert.IsTrue(true);
    //            else
    //                Assert.Fail();
    //        }
    //    }
    //    [TestMethod()]
    //    public void EliminarTestAdjunto()
    //    {
    //        var adjuntoTask = repoAdjunto.ObtenerAsync(x => x.AdjuntoId.Contains("seed.txt"), CancellationToken.None);
    //        Task.WaitAll(adjuntoTask);
    //        if (adjuntoTask.Result == null)
    //            Assert.Fail();
    //        else
    //        {
    //            var aTask = repoAdjunto.Eliminar(adjuntoTask.Result);
    //            Task.WaitAll(aTask);
    //            if (aTask.Result > 0)
    //                Assert.IsTrue(true);
    //            else
    //                Assert.Fail();
    //        }
    //    }
    }
}