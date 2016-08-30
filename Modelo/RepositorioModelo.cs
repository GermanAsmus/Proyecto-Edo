using CapaInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Modelo
{
    public class RepositorioModelo<T> : IRepositorioCompleto<T> where T : class
    {
        private IList<T> iFuente;

        public RepositorioModelo(IList<T> pFuente)
        {
            this.iFuente = pFuente;
        }

        public int Actualizar()
        {
            throw new NotImplementedException();
        }

        public int Agregar(T pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));
            this.iFuente.Add(pEntidad);
            return 1;
        }

        public int Eliminar(T pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));
            this.iFuente.Remove(pEntidad);
            return 1;
        }

        public T Obtener(Expression<Func<T, bool>> pCriterio)
        {
            return this.iFuente.AsQueryable().SingleOrDefault(pCriterio);
        }

        public IEnumerable<T> ObtenerSegun(Expression<Func<T, bool>> pCriterio)
        {
            return this.iFuente.AsQueryable().Where(pCriterio);
        }

        public IEnumerable<T> Todos()
        {
            return this.iFuente;
        }
    }
}
