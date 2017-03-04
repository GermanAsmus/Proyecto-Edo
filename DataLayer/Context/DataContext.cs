using System;
using System.Data.Entity;

namespace DataLayer
{
    internal class DataContext : IDataContext
    {
        public EF_Context Context { get; set; }

        public DataContext()
        {
            this.Context = new EF_Context();
        }

        public int Commit()
        {
            return Context.SaveChanges();
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
                }
            }

        }
    }
}