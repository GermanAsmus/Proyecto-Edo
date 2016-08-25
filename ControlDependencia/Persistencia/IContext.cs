namespace CapaInterfaces.Persistencia
{
    public interface IContext
    {
        int Commit();
        void Dispose();
    }
}