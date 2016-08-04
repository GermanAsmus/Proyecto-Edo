using ControlDependencia;

namespace EdoUI
{
    public class StartEdo : IStartEdo
    {
        public void Run()
        {
            RunEdo.Main();
        }
    }
}