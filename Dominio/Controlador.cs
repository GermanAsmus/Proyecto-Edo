using CapaInterfaces;
using CapaInterfaces.Dominio;
using CapaInterfaces.Persistencia;
using CapaInterfaces.Servicio;
using CapaInterfaces.Utilidades;
using System;
using System.Collections.Generic;
using Utilidades.CriteriosDeBusqueda;
using System.Threading;
using Dominio.Repositorios;
using EdoUI;
using CapaInterfaces.Modelo;

namespace Dominio
{
    public class Controlador : IControlador
    {
        public IGestorRespositorios GestorRepositorios { get; private set; }
        private IServicio iServicio;

        public Controlador(IUnitOfWork pUnitOfWork)
        {
            iServicio = IoC_CL.Resolver<IServicio>();
            GestorRepositorios = new GestorRepositorios(pUnitOfWork);
        }
        public int AregarCuenta(IDireccionCorreo pDireccion, ICuenta pCuenta)
        {
            IRepositorioCompleto<ICuenta> aRepositorioCuenta = this.GestorRepositorios.ObtenerRepositorio<ICuenta>();
            return aRepositorioCuenta.Agregar(pCuenta);
        }
        public int EditarCuenta(ICuenta pCuenta)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuenta>();
            return aRepositorio.Actualizar();
        }
        public int EditarDireccionDeCorreo(IDireccionCorreo pDireccionCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreo>();
            return aRepositorio.Actualizar();
        }
        public int EliminarDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreo>();
            IDireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pId);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public int EliminarDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreo>();
            IDireccionCorreo unaDireccion = this.ObtenerDireccionDeCorreo(pDireccionDeCorreo);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public IDireccionCorreo ObtenerDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreo>();
            IDireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorCuentaId(x, pId));
            if (unaDireccion == null)
                throw new Exception("La direccion de correo no existe en el sistema");
            return unaDireccion;
        }
        public IDireccionCorreo ObtenerDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreo>();
            IDireccionCorreo unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorDireccion(x, pDireccionDeCorreo));
            if (unaDireccion == null)
                throw new Exception("La direccion de correo no existe en el sistema");
            return unaDireccion;
        }
        public IEnumerable<IDireccionCorreo> ObtenerTodasLasDireccionesDeCorreo()
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreo>();
            return aRepositorio.Todos();
        }
        public int EliminarMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensaje>();
            IMensaje unMensaje = this.ObtenerMensaje(pId);
            return aRepositorio.Eliminar(unMensaje);
        }
        public int EliminarMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensaje>();
            IMensaje unMensaje = this.ObtenerMensaje(pAsunto);
            return aRepositorio.Eliminar(unMensaje);
        }
        public IMensaje ObtenerMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensaje>();
            IMensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorId(x, pId));
            if (unMensaje == null)
                throw new Exception("El menasje no existe en el sistema");
            return unMensaje;
        }
        public IMensaje ObtenerMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensaje>();
            IMensaje unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorAsunto(x, pAsunto));
            if (unMensaje == null)
                throw new Exception("El menasje no existe en el sistema");
            return unMensaje;
        }
        public IEnumerable<IMensaje> ObtenerTodosLosMensajes()
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensaje>();
            return aRepositorio.Todos();
        }
        public int EliminarCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuenta>();
            ICuenta unaCuenta = this.ObtenerCuenta(pId);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public int EliminarCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuenta>();
            ICuenta unaCuenta = this.ObtenerCuenta(pNombre);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public ICuenta ObtenerCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuenta>();
            ICuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorId(x, pId));
            if (unaCuenta == null)
                throw new Exception("La cuenta no existe en el sistema");
            return unaCuenta;
        }
        public ICuenta ObtenerCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuenta>();
            ICuenta unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorNombre(x, pNombre));
            if (unaCuenta == null)
                throw new Exception("La cuenta no existe en el sistema");
            return unaCuenta;
        }
        public IEnumerable<ICuenta> ObtenerTodasLasCuentas()
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuenta>();
            return aRepositorio.Todos();
        }
        public void Enviar(IMensaje pMensaje, ICuenta pCuenta)
        {
            //poner un estado de enviado o no enviado(por las dudas)

            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            if (pCuenta == null)
                throw new ArgumentNullException(nameof(pCuenta));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pMensaje.Asunto))
                throw new NullReferenceException("El asunto del IMensaje no puede ser vacío o nulo");

            //verifica cada una de las direcciones de correo
            List<IDireccionCorreo> destinatariosValidos = new List<IDireccionCorreo>();
            var destinatarios = pMensaje.Destinatario.GetEnumerator();

            IRepositorioCompleto<IDireccionCorreo> aRepositorioDireccionCorreo = this.GestorRepositorios.ObtenerRepositorio<IDireccionCorreo>();
            IDireccionCorreo iDireccion = null;
            while (destinatarios.MoveNext())
            {
                iDireccion = aRepositorioDireccionCorreo.Obtener(d => BuscarDireccionDeCorreo.BuscarPorDireccion(d, destinatarios.Current.DireccionDeCorreo));
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pMensaje.Destinatario = destinatariosValidos;

            IRepositorioCompleto<ICuenta> aRepositorioCuenta = this.GestorRepositorios.ObtenerRepositorio<ICuenta>();
            ICuentaUsuario iCuenta = (ICuentaUsuario)aRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pCuenta.Id));
            if (iCuenta == null)
                throw new NullReferenceException(nameof(iCuenta));

            iCuenta.Mensajes.Add(pMensaje);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la ICuenta.
            pMensaje.CuentaId = iCuenta.Id;
            //Se actualiza la ICuenta, que mantiene una colección de mensajes.
            aRepositorioCuenta.Actualizar();

            IProtocoloTransmision iProtocoloTransmision = IoC_CL.Resolver<IProtocoloTransmision>();
            this.iServicio.Enviar(pMensaje, pCuenta, iProtocoloTransmision);
        }
        public void Recibir(CancellationToken pCancellation,ICuenta pCuenta, ref IBuzon pBuzon)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoC_CL.Resolver<IProtocoloRecepcion>();
            this.iServicio.Descargar(pCancellation, pCuenta, iProtocoloRecepcion, ref pBuzon);
        }
        public void Recibir(int pIdMensaje, CancellationToken pCancellation, ICuenta pCuenta,ref IBuzon pBuzon)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoC_CL.Resolver<IProtocoloRecepcion>();
            this.iServicio.Descargar(pIdMensaje, pCancellation, pCuenta, iProtocoloRecepcion,ref pBuzon);
        }
        public void EliminarDelServidor(int pId, ICuenta pCuenta)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoC_CL.Resolver<IProtocoloRecepcion>();
            this.iServicio.Eliminar(pId, pCuenta, iProtocoloRecepcion);
        }

    }
}
