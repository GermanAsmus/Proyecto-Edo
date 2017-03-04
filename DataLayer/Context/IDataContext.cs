using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataLayer
{
    internal interface IDataContext : IDisposable
    {
        EF_Context Context { get; }
        int Commit();
    }
}