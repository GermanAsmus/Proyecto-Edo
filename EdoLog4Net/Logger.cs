using System.Runtime.CompilerServices;

namespace EdoLog4Net
{
    public static class Logger
    {
       public static log4net.ILog ObtenerLogger([CallerFilePath]string pNombreArchivo = "")
        {
            return log4net.LogManager.GetLogger(pNombreArchivo);
        } 
    }
}
