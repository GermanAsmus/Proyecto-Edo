using System;
using System.Collections.Generic;
using ControlDependencia;
using ControlDependencia.Persistencia;
using System.Linq;
using Modelo;
using UnityDI;

namespace Persistencia
{
    public class UnitOfWork : IUnitOfWork
    {
        public ControlDependencia.Persistencia.IContext Context { get; set; }
        public ICollection<IRepositorioRaiz> Repositorios { get; }

        public UnitOfWork(IContext pContext)
        {
            this.Context = pContext;

            this.Repositorios.Add(IoCContainer.Resolver<IRepositorioUnico<Cuenta>>());
            this.Repositorios.Add(IoCContainer.Resolver<IRepositorioUnico<Mensaje>>());
            //this.Repositorios.Add(EdoUnity.IoCContainer.Resolver<IRepositorioUnico<Servidor>>());
            this.Repositorios.Add(IoCContainer.Resolver<IRepositorioUnico<Adjunto>>());
            this.Repositorios.Add(IoCContainer.Resolver<IRepositorioUnico<DireccionCorreo>>());
        }
        public IRepositorioUnico<T> ObtenerRepositorio<T>() where T : class
        {
            return (IRepositorioUnico<T>)this.Repositorios.FirstOrDefault(x => x.GetType().GetGenericTypeDefinition() == typeof(T));
        }


        public int Commit()
        {
            return Context.Commit();
        }

        public void Dispose()
        {
            try
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("El garbage collector no puede finalizar con el finalizar con la instancia del UnitOfWork porque ya es nula", ex);
            }
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                    Context = null;
                }
            }

        }
    }
}
