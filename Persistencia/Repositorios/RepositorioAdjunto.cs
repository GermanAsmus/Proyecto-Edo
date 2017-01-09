using EdoUI.Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Persistencia.Repositorios
{
    public class RepositorioAdjunto : Repositorio<IAdjunto>, IRepositorioAdjunto
    {
        public RepositorioAdjunto(IDbSet<IAdjunto> pDbSet) : base(pDbSet)
        {

        }

        public override void Agregar(IAdjunto entity)
        {
            this.AgregarEntidad(entity);
        }

        public IAdjunto Obtener(int pId)
        {
           return base.Obtener(adjunto => adjunto.Id == pId);
        }

        public IAdjunto Obtener(string pCodigo)
        {
            return base.Obtener(adjunto => adjunto.PathAdjunto == pCodigo);
        }

        public IEnumerable<IAdjunto> ObtenerSegun(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerSegun(adjunto => adjunto.Id == pId);
            else
                return base.ObtenerSegun();
        }

        public IEnumerable<IAdjunto> ObtenerSegun(string pCodigo = null)
        {
            if (!string.IsNullOrEmpty(pCodigo))
                return base.ObtenerSegun(adjunto => adjunto.PathAdjunto == pCodigo);
            else
                return base.ObtenerSegun();

        }
    }
}
