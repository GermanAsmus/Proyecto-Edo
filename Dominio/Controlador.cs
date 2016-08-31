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
        public int AregarCuenta(IDireccionCorreoDTO pDireccion, ICuentaDTO pCuenta)
        {
            IRepositorioCompleto<ICuentaDTO> aRepositorioCuenta = this.GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            return aRepositorioCuenta.Agregar(pCuenta);
        }
        public int EditarCuenta(ICuentaDTO pCuenta)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            return aRepositorio.Actualizar();
        }
        public int EditarDireccionDeCorreo(IDireccionCorreoDTO pDireccionCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreoDTO>();
            return aRepositorio.Actualizar();
        }
        public int EliminarDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreoDTO>();
            IDireccionCorreoDTO unaDireccion = this.ObtenerDireccionDeCorreo(pId);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public int EliminarDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreoDTO>();
            IDireccionCorreoDTO unaDireccion = this.ObtenerDireccionDeCorreo(pDireccionDeCorreo);
            return aRepositorio.Eliminar(unaDireccion);
        }
        public IDireccionCorreoDTO ObtenerDireccionDeCorreo(int pId)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreoDTO>();
            IDireccionCorreoDTO unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorCuentaId(x, pId));
            if (unaDireccion == null)
                throw new Exception("La direccion de correo no existe en el sistema");
            return unaDireccion;
        }
        public IDireccionCorreoDTO ObtenerDireccionDeCorreo(string pDireccionDeCorreo)
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreoDTO>();
            IDireccionCorreoDTO unaDireccion = aRepositorio.Obtener(x => BuscarDireccionDeCorreo.BuscarPorDireccion(x, pDireccionDeCorreo));
            if (unaDireccion == null)
                throw new Exception("La direccion de correo no existe en el sistema");
            return unaDireccion;
        }
        public IEnumerable<IDireccionCorreoDTO> ObtenerTodasLasDireccionesDeCorreo()
        {
            RepositorioDireccion aRepositorio = (RepositorioDireccion)GestorRepositorios.ObtenerRepositorio<IDireccionCorreoDTO>();
            return aRepositorio.Todos();
        }
        public int EliminarMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensajeDTO>();
            IMensajeDTO unMensaje = this.ObtenerMensaje(pId);
            return aRepositorio.Eliminar(unMensaje);
        }
        public int EliminarMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensajeDTO>();
            IMensajeDTO unMensaje = this.ObtenerMensaje(pAsunto);
            return aRepositorio.Eliminar(unMensaje);
        }
        public IMensajeDTO ObtenerMensaje(int pId)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensajeDTO>();
            IMensajeDTO unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorId(x, pId));
            if (unMensaje == null)
                throw new Exception("El menasje no existe en el sistema");
            return unMensaje;
        }
        public IMensajeDTO ObtenerMensaje(string pAsunto)
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensajeDTO>();
            IMensajeDTO unMensaje = aRepositorio.Obtener(x => BuscarMensaje.BuscarPorAsunto(x, pAsunto));
            if (unMensaje == null)
                throw new Exception("El menasje no existe en el sistema");
            return unMensaje;
        }
        public IEnumerable<IMensajeDTO> ObtenerTodosLosMensajes()
        {
            RepositorioMensaje aRepositorio = (RepositorioMensaje)GestorRepositorios.ObtenerRepositorio<IMensajeDTO>();
            return aRepositorio.Todos();
        }
        public int EliminarCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            ICuentaDTO unaCuenta = this.ObtenerCuenta(pId);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public int EliminarCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            ICuentaDTO unaCuenta = this.ObtenerCuenta(pNombre);
            return aRepositorio.Eliminar(unaCuenta);
        }
        public ICuentaDTO ObtenerCuenta(int pId)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            ICuentaDTO unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorId(x, pId));
            if (unaCuenta == null)
                throw new Exception("La cuenta no existe en el sistema");
            return unaCuenta;
        }
        public ICuentaDTO ObtenerCuenta(string pNombre)
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            ICuentaDTO unaCuenta = aRepositorio.Obtener(x => BuscarCuenta.BuscarPorNombre(x, pNombre));
            if (unaCuenta == null)
                throw new Exception("La cuenta no existe en el sistema");
            return unaCuenta;
        }
        public IEnumerable<ICuentaDTO> ObtenerTodasLasCuentas()
        {
            RepositorioCuenta aRepositorio = (RepositorioCuenta)GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            return aRepositorio.Todos();
        }
        public void Enviar(IMensajeDTO pMensaje, ICuentaDTO pCuenta)
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
            List<IDireccionCorreoDTO> destinatariosValidos = new List<IDireccionCorreoDTO>();
            var destinatarios = pMensaje.Destinatario.GetEnumerator();

            IRepositorioCompleto<IDireccionCorreoDTO> aRepositorioDireccionCorreo = this.GestorRepositorios.ObtenerRepositorio<IDireccionCorreoDTO>();
            IDireccionCorreoDTO iDireccion = null;
            while (destinatarios.MoveNext())
            {
                iDireccion = aRepositorioDireccionCorreo.Obtener(d => BuscarDireccionDeCorreo.BuscarPorDireccion(d, destinatarios.Current.DireccionDeCorreo));
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pMensaje.Destinatario = destinatariosValidos;

            IRepositorioCompleto<ICuentaDTO> aRepositorioCuenta = this.GestorRepositorios.ObtenerRepositorio<ICuentaDTO>();
            ICuentaUsuarioDTO iCuenta = (ICuentaUsuarioDTO)aRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pCuenta.Id));
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
        public void Recibir(CancellationToken pCancellation,ICuentaDTO pCuenta, ref IBuzon pBuzon)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoC_CL.Resolver<IProtocoloRecepcion>();
            this.iServicio.Descargar(pCancellation, pCuenta, iProtocoloRecepcion, ref pBuzon);
        }
        public void Recibir(int pIdMensaje, CancellationToken pCancellation, ICuentaDTO pCuenta,ref IBuzon pBuzon)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoC_CL.Resolver<IProtocoloRecepcion>();
            this.iServicio.Descargar(pIdMensaje, pCancellation, pCuenta, iProtocoloRecepcion,ref pBuzon);
        }
        public void EliminarDelServidor(int pId, ICuentaDTO pCuenta)
        {
            IProtocoloRecepcion iProtocoloRecepcion = IoC_CL.Resolver<IProtocoloRecepcion>();
            this.iServicio.Eliminar(pId, pCuenta, iProtocoloRecepcion);
        }

    }
}
