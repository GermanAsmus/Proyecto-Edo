using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DI
{
    public class IoCContainer
    {
        public static T Resolver<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
