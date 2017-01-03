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
    public class RepositorioAdjunto : Repositorio<IAdjuntoDTO>, IRepositorioAdjunto
    {
        public RepositorioAdjunto(IDbSet<IAdjuntoDTO> pDbSet) : base(pDbSet)
        {

        }

        public override void Agregar(IAdjuntoDTO entity)
        {
            this.AgregarEntidad(entity);
        }

        public IAdjuntoDTO Obtener(int pId)
        {
           return base.Obtener(adjunto => adjunto.Id == pId);
        }

        public IAdjuntoDTO Obtener(string pCodigo)
        {
            return base.Obtener(adjunto => adjunto.PathAdjunto == pCodigo);
        }

        public IEnumerable<IAdjuntoDTO> ObtenerSegun(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerSegun(adjunto => adjunto.Id == pId);
            else
                return base.ObtenerSegun();
        }

        public IEnumerable<IAdjuntoDTO> ObtenerSegun(string pCodigo = null)
        {
            if (!string.IsNullOrEmpty(pCodigo))
                return base.ObtenerSegun(adjunto => adjunto.PathAdjunto == pCodigo);
            else
                return base.ObtenerSegun();

        }
    }
}
