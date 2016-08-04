﻿using ControlDependencia;
using ControlDependencia.Dominio;

namespace UnityDI
{
    public static class Program
    {
        static void Main()
        {
            // IoCContainer.iPathConfigFile= @"C:\Users\german\Source\Repos\UnityDI\UnityDI\Unity.config";
            //IoCContainer.Resolver<IStartEdo>().Run();
            IoCContainer.Resolver<IControlador>();
        }
    }
}
