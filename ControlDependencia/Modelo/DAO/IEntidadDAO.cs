using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface IEntidadDAO<TEntity> : IObtenible<TEntity> where TEntity : IEntidadModelo
    {
        void Agregar(TEntity pEntidad);
        void Eliminar(TEntity pEntidad);
    }
}
