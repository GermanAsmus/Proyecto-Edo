using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using System.Reflection;

namespace EdoUnity
{
    public static class IoCContainer
    {
        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {
            // Se crea la instancia del contenedor, configurando el mismo a través del archivo de configuración de la aplicación.

            //var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = "App.config" };
            //Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            //var unitySection = (UnityConfigurationSection)configuration.GetSection("unity");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            UnityConfigurationSection section = (UnityConfigurationSection)config.GetSection("unity");
            IUnityContainer mUnityContainer = new UnityContainer();
            section.Configure(mUnityContainer);

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
