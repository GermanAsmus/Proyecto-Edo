using System;
using System.Collections.Generic;
using ControlDependencia;
using ControlDependencia.Persistencia;
using System.Linq;
using Modelo;

namespace Persistencia
{
    public class UnitOfWork : IUnitOfWork
    {
        public ControlDependencia.Persistencia.IContext Context { get; set; }
        public ICollection<IRepositorioRaiz> Repositorios { get; }

        public UnitOfWork(IContext pContext)
        {
            this.Context = pContext;

            this.Repositorios.Add(EdoUnity.IoCContainer.Resolver<IRepositorio<Cuenta>>());
            this.Repositorios.Add(EdoUnity.IoCContainer.Resolver<IRepositorio<Mensaje>>());
            this.Repositorios.Add(EdoUnity.IoCContainer.Resolver<IRepositorio<Servidor>>());
            this.Repositorios.Add(EdoUnity.IoCContainer.Resolver<IRepositorio<Adjunto>>());
            this.Repositorios.Add(EdoUnity.IoCContainer.Resolver<IRepositorio<DireccionCorreo>>());
        }
        public IRepositorio<T> ObtenerRepositorio<T>() where T : class
        {
            return (IRepositorio<T>)this.Repositorios.FirstOrDefault(x => x.GetType().GetGenericTypeDefinition() == typeof(T));
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
