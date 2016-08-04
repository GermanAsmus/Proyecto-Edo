using ControlDependencia.Persistencia;

namespace ControlDependencia
{
    static class Program
    {
        static void Main()
        {
            // IoCContainer.iPathConfigFile= @"C:\Users\german\Source\Repos\UnityDI\UnityDI\Unity.config";
            //IoCContainer.Resolver<IStartEdo>().Run();
            IoC_CL.Resolver<IUnitOfWork>();
        }
    }
}
