﻿using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio
{
    public class RepositorioBaseDireccion : AgregarSimple<DireccionCorreo>
    {
        public RepositorioBaseDireccion(IRepositorio<DireccionCorreo> iRepositorio, IGestor pGestor) : base(iRepositorio, pGestor)
        {
            //Constructor
        }

        public override async Task Agregar(DireccionCorreo entidad)
        {
            DireccionCorreo direccionResidente = await this.Obtener(x => x.DireccionId == entidad.DireccionId);
            await this.Repositorio.Agregar(entidad);

            //var taskAgregar = this.Repositorio.Agregar(entidad);
            //Task.WaitAll(taskAgregar);
            //if (taskAgregar.Result == 0)
            //    throw new ApplicationException("Agregar");
        }
    }
}
