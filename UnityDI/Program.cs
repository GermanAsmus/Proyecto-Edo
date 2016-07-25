using ControlDependencia;
namespace UnityDI
{
    public static class Program
    {
        static void Main()
        {
           // IoCContainer.iPathConfigFile= @"C:\Users\german\Source\Repos\UnityDI\UnityDI\Unity.config";
            IoCContainer.Resolver<IStartEdo>().Run();
        }
    }
}
