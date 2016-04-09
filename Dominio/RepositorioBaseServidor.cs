﻿using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Dominio
{
    public class RepositorioBaseServidor : AgregarSimple<Servidor>
    {
        public RepositorioBaseServidor(IRepositorio<Servidor> pRepositorio) : base(pRepositorio)
        {
            //Constructor
        }

        public override void Agregar(Servidor entidad)
        {
            //
        }
    }
}
