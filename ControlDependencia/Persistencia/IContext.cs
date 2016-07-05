namespace ControlDependencia.Persistencia
{
    public interface IContext
    {
        int Commit();
        void Dispose();
    }
}