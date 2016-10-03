﻿using CapaInterfaces;
using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class RepositorioAdjunto : Repositorio<IAdjuntoDTO>
    {
        public RepositorioAdjunto(IDbSet<IAdjuntoDTO> pDbSet):base (pDbSet)
        {

        }
        public override void Agregar(IAdjuntoDTO entity)
        {
            this.AgregarEntidad(entity);
        }
    }
}
