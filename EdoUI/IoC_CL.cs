using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdoUI
{
    public static class IoC_CL
    {
        /// <summary>
        /// Instancia lazy del contenedor de IoC.
        /// </summary>
        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {
            // Se crea la instancia del contenedor, configurando el mismo a través del archivo de configuración de la aplicación.

            IUnityContainer mUnityContainer = new UnityContainer();

            mUnityContainer.LoadConfiguration();

            return mUnityContainer;
        });

        private static IUnityContainer Container
        {
            get { return cInstance.Value; }
        }

        public static T Resolver<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
