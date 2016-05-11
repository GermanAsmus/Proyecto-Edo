using System.Runtime.InteropServices;

namespace Utilidades.Internet
{
    public class VerificarConexion
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int Reserved);

        public static bool ObtenerEstadoConexion()
        {
            int Descript;
            return InternetGetConnectedState(out Descript, 0);
        }
    }
}
