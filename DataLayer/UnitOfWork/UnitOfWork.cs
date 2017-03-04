using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Dominio;

namespace DataLayer
{
    internal class UnitOfWork : IUnitOfWork
    {
        private IDataContext iContext;
        public IRepositorio<ICuentaDeUsuario> RepositorioCuenta { get; private set; }

        public UnitOfWork()
        {
            this.RepositorioCuenta = new Repositorio<ICuentaDeUsuario>(ref this.iContext);
        }
    }
}
