using CapaInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Mail;
using CapaInterfaces.Persistencia;
using CapaInterfaces.Dominio;
using Dominio.Repositorios;
using CapaInterfaces.Modelo;

namespace Dominio
{
    public class GestorRepositorios : IGestorRespositorios
    {
        public IDictionary<Type, IRepositorioRaiz> Repositorios { get; }
        /// <summary>
        /// Constructor del GestorRepositorios.
        /// Se instancian los repositorios y se los agregan al disccionario Repositorios.
        /// </summary>
        /// <param name="pUoW">Unit of Work</param>
        public GestorRepositorios(IUnitOfWork pUoW)
        {
            Repositorios = new Dictionary<Type, IRepositorioRaiz>();
            Repositorios.Add(typeof(IDireccionCorreoDTO), new RepositorioDireccion(pUoW.ObtenerRepositorio<IDireccionCorreoDTO>()));
            
            //Repositorios.Add(typeof(Adjunto), new RepositorioAdjunto(pUoW.ObtenerRepositorio<Adjunto>(),this));
            Repositorios.Add(typeof(ICuentaDTO), new RepositorioCuenta(pUoW.ObtenerRepositorio<ICuentaDTO>(),this.ObtenerRepositorio<IDireccionCorreoDTO>()));

            Repositorios.Add(typeof(IMensajeDTO), new RepositorioMensaje(pUoW.ObtenerRepositorio<IMensajeDTO>(), this.ObtenerRepositorio<IDireccionCorreoDTO>(), this.ObtenerRepositorio<ICuentaDTO>()));
        }

        public IRepositorioCompleto<TEntity> ObtenerRepositorio<TEntity>() where TEntity : class, IEntidadModelo
        {
            return (IRepositorioCompleto<TEntity>)this.Repositorios[typeof(TEntity)]; 
        }
    }
}
