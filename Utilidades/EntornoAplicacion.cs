using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class EntornoAplicacion
    {
        private static string iRootPath = "Email Dev One";

        public static string DirectorioEntorno
        {
            get
            {
                string ifullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), iRootPath);
                if (!Directory.Exists(ifullPath))
                    Directory.CreateDirectory(ifullPath);
                return ifullPath;
            }
        }
    }
}
