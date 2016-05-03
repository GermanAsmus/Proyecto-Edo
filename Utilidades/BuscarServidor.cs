using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class BuscarServidor : CriterioDeBusqueda<Servidor>
    {
        public new static Func<Servidor, int, bool> BuscarPorId = (pEntidad, pId) => pEntidad.Id == pId;
        public static Func<Servidor, string, bool> BuscarPorNombre = (pEntidad, pNombre) => pEntidad.Nombre == pNombre;
    }
}
