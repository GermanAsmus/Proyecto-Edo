using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Utilidades;

namespace Dominio
{
    public class Controlador : IControlador
    {
        private IGestorRespositorios iGestorRepositorios;
        private IServicio iServicio;

        public Controlador(IUnitOfWork pUnitOfWork, IServicio pServicio)
        {
            iGestorRepositorios = new GestorRepositorios(pUnitOfWork);
            iServicio = pServicio;
        }
        /// <summary>
        /// Agrega un adjunto a un mensaje
        /// </summary>
        /// <param name="pAdjunto">archivo adjunto</param>
        /// <param name="pMensaje">mensaje</param>
        /// <returns></returns>
        public int AregarAdjunto(Adjunto pAdjunto, Mensaje pMensaje)
        {
            RepositorioAdjunto aRepositorio = (RepositorioAdjunto)iGestorRepositorios.ObtenerRepositorio<Adjunto>();
            return aRepositorio.Agregar(pAdjunto, pMensaje);
        }
        /// <summary>
        /// Agrega una cuenta respectiva a un servidor
        /// </summary>
        /// <param name="pCuenta">cuenta nueva</param>
        /// <param name="pServidor">servidor de correo {ej: gmail, yahoo}</param>
        /// <returns></returns>
        public int AregarCuenta(Cuenta pCuenta, Servidor pServidor)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.Agregar(pCuenta, pServidor);
        }
        /// <summary>
        /// Agrega una direccion de correo
        /// </summary>
        /// <param name="pDireccionCorreo">nueva direccion de correo</param>
        /// <returns></returns>
        public int AregarDireccionDeCorreo(DireccionCorreo pDireccionCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.Agregar(pDireccionCorreo);
        }
        /// <summary>
        /// Confirmacion de la edicion de una cuenta
        /// </summary>
        /// <param name="pCuenta">cuenta modificada</param>
        /// <returns></returns>
        public int EditarCuenta(Cuenta pCuenta)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.Editar(pCuenta);
        }
        /// <summary>
        /// Confirmacion de la edicion de una direccion de correo
        /// </summary>
        /// <param name="pDireccionCorreo">direccion de correo modificada</param>
        /// <returns></returns>
        public int EditarDireccionDeCorreo(DireccionCorreo pDireccionCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.Editar(pDireccionCorreo);
        }
        /// <summary>
        /// Confirmacion de la edicion de un mensaje
        /// </summary>
        /// <param name="pMensaje">mensaje modificado</param>
        /// <returns></returns>
        public int EditarMensaje(Mensaje pMensaje)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            return aRepositorio.Editar(pMensaje);
        }
        /// <summary>
        ///Elimina un mensaje del servidor de correo
        /// </summary>
        /// <param name="pCriterio"></param>
        public void EliminarMensajeDelServidorDeCorreo(ICriterio<Mensaje> pCriterio)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Elimina un adjunto mediante su id
        /// </summary>
        /// <param name="pId">Identificador del adjunto</param>
        /// <returns></returns>
        public int EliminarAdjunto(int pId)
        {
            RepositorioAdjunto aRepositorio = (RepositorioAdjunto)iGestorRepositorios.ObtenerRepositorio<Adjunto>();
            Adjunto unAdjunto = this.ObtenerAdjunto(pId);
            return aRepositorio.Eliminar(unAdjunto);
        }
        /// <summary>
        /// Elimina un adjunto mediante su codigo de localizacion(path), en donde se encuentra
        /// </summary>
        /// <param name="pCodigo">path del archivo adjunto</param>
        /// <returns></returns>
        public int EliminarAdjunto(string pCodigo)
        {
            RepositorioAdjunto aRepositorio = (RepositorioAdjunto)iGestorRepositorios.ObtenerRepositorio<Adjunto>();
            Adjunto unAdjunto = this.ObtenerAdjunto(pCodigo);
            return aRepositorio.Eliminar(unAdjunto);
        }
        /// <summary>
        /// Elimina una direccion de correo de la base de datos mediante el Id
        /// </summary>
        /// <param name="pId">identificador de la direccion de correo</param>
        /// <returns></returns>
        public int EliminarDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pId);
            return aRepositorio.Eliminar(unaDireccion);
        }
        /// <summary>
        /// Elimina una direccion de correo de la base de datos mediante el usuario de la direccion de correo
        /// </summary>
        /// <param name="pDireccionDeCorreo">Usuario de la direccion de correo</param>
        /// <returns></returns>
        public int EliminarDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pDireccionDeCorreo);
            return aRepositorio.Eliminar(unaDireccion);
        }
        /// <summary>
        /// Obtiene la direccion de correo mediante el Id
        /// </summary>
        /// <param name="pId">Identificador de la direccion de correo</param>
        /// <returns>Direccion de correo</returns>
        public DireccionCorreo ObtenerDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorCuentaId(x, pId));
            if (unaDireccion == null)
                throw new Exception("No existe la direccion de correo en la bd");
            return unaDireccion;
        }
        /// <summary>
        /// Obtiene la direccion de correo mediante el usuario de la direccion de correo
        /// </summary>
        /// <param name="pDireccionDeCorreo">Usuario de la direccion de correo</param>
        /// <returns>Direccion de correo</returns>
        public DireccionCorreo ObtenerDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            DireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorDireccion(x, pDireccionDeCorreo));
            if (unaDireccion == null)
                throw new Exception("No existe la direccion de correo en la bd");
            return unaDireccion;
        }
        /// <summary>
        /// Obtiene todas las direcciones de correo
        /// </summary>
        /// <returns>Colección de direcciones de correo</returns>
        public IEnumerable<DireccionCorreo> ObtenerTodasLasDireccionesDeCorreo()
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)iGestorRepositorios.ObtenerRepositorio<DireccionCorreo>();
            return aRepositorio.ObtenerTodos();
        }
        /// <summary>
        /// Obtiene un adjunto mediante el Id
        /// </summary>
        /// <param name="pId">Identificador del adjunto</param>
        /// <returns>Adjunto</returns>
        public Adjunto ObtenerAdjunto(int pId)
        {
            RepositorioAdjunto aRepositorio = (RepositorioAdjunto)iGestorRepositorios.ObtenerRepositorio<Adjunto>();
            Adjunto unAdjunto = aRepositorio.Obtener(x => BuscarAdjunto.BuscarPorId(x, pId));
            if(unAdjunto==null)
                throw new Exception("No existe el adjunto en la bd");
            return unAdjunto;
        }
        /// <summary>
        /// Obtiene un adjunto mediante el codigo del path en donde se encuentra el archivo adjunto
        /// </summary>
        /// <param name="pCodigo">Path del adjunto</param>
        /// <returns>Adjunto</returns>
        public Adjunto ObtenerAdjunto(string pCodigo)
        {
            RepositorioAdjunto aRepositorio = (RepositorioAdjunto)iGestorRepositorios.ObtenerRepositorio<Adjunto>();
            Adjunto unAdjunto = aRepositorio.Obtener(x => BuscarAdjunto.BuscarPorCodigo(x, pCodigo));
            if (unAdjunto == null)
                throw new Exception("No existe el adjunto en la bd");
            return unAdjunto;
        }
        /// <summary>
        /// Obtiene todos los adjuntos
        /// </summary>
        /// <returns>Coleccion de Adjuntos</returns>
        public IEnumerable<Adjunto> ObtenerTodosLosAdjuntos()
        {
            RepositorioAdjunto aRepositorio = (RepositorioAdjunto)iGestorRepositorios.ObtenerRepositorio<Adjunto>();
            return aRepositorio.ObtenerTodos();
        }
        /// <summary>
        /// Elimina un mensaje mediante el Id
        /// </summary>
        /// <param name="pId">Identificador del mensaje</param>
        /// <returns></returns>
        public int EliminarMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = this.ObtenerMensaje(pId);
            return aRepositorio.Eliminar(unMensaje);
        }
        /// <summary>
        /// Elimina un mensaje mediante el Asunto
        /// </summary>
        /// <param name="pAsunto">Asunto del mensaje</param>
        /// <returns></returns>
        public int EliminarMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = this.ObtenerMensaje(pAsunto);
            return aRepositorio.Eliminar(unMensaje);
        }
        /// <summary>
        /// Obtiene un mensaje mediante su Id
        /// </summary>
        /// <param name="pId">Identificador del Mensaje</param>
        /// <returns>Mensaje</returns>
        public Mensaje ObtenerMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorId(x, pId));
            if (unMensaje == null)
                throw new Exception("el mensaje no existe en la bd");
            return unMensaje;
        }
        /// <summary>
        /// Obtiene un mensaje mediante su asunto
        /// </summary>
        /// <param name="pAsunto">Asunto del mensaje</param>
        /// <returns></returns>
        public Mensaje ObtenerMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            Mensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorAsunto(x, pAsunto));
            if (unMensaje == null)
                throw new Exception("el mensaje no existe en la bd");
            return unMensaje;
        }
        /// <summary>
        /// Obtiene todos los mensajes
        /// </summary>
        /// <returns>Coleccion de mensajes</returns>
        public IEnumerable<Mensaje> ObtenerTodosLosMensajes()
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)iGestorRepositorios.ObtenerRepositorio<Mensaje>();
            return aRepositorio.ObtenerTodos();
        }
        /// <summary>
        /// Elimina una cuenta mediante el Id
        /// </summary>
        /// <param name="pId">Identificador de la cuenta</param>
        /// <returns></returns>
        public int EliminarCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = this.ObtenerCuenta(pId);
            return aRepositorio.Eliminar(unaCuenta);
        }
        /// <summary>
        /// Elimina una cuenta mediante el nombre
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta</param>
        /// <returns></returns>
        public int EliminarCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = this.ObtenerCuenta(pNombre);
            return aRepositorio.Eliminar(unaCuenta);
        }
        /// <summary>
        /// Obtiene una cuenta mediante su Id
        /// </summary>
        /// <param name="pId">Identificador de la cuenta</param>
        /// <returns>Cuenta</returns>
        public Cuenta ObtenerCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorId(x, pId));
            if (unaCuenta == null)
                throw new Exception("la cuenta no existe en la bd");
            return unaCuenta;
        }
        /// <summary>
        /// Obtiene una cuenta mediante su nombre
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta</param>
        /// <returns>Cuenta</returns>
        public Cuenta ObtenerCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            Cuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorNombre(x, pNombre));
            if (unaCuenta == null)
                throw new Exception("la cuenta no existe en la bd");
            return unaCuenta;
        }
        /// <summary>
        /// Obtiene todas las cuentas
        /// </summary>
        /// <returns>Coleccion de todas las cuentas</returns>
        public IEnumerable<Cuenta> ObtenerTodasLasCuentas()
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)iGestorRepositorios.ObtenerRepositorio<Cuenta>();
            return aRepositorio.ObtenerTodos();
        }

        public void Enviar(Mensaje pMensaje, Cuenta pCuenta)
        {
            throw new NotImplementedException();
        }

        public void Recibir(Cuenta pCuenta)
        {
            throw new NotImplementedException();
        }

        public void EliminarDelServidor(int pId)
        {
            throw new NotImplementedException();
        }
    }
}
