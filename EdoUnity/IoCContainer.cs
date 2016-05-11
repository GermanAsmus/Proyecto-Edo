using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;

namespace EdoUnity
{
    public static class IoCContainer
    {
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
