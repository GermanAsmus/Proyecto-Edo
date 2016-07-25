using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;


namespace UnityDI
{
    public static class IoCContainer
    {
        //public static string iPathConfigFile { get; set; }

        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {

            //if (iPathConfigFile == null)
            //    throw new NullReferenceException(nameof(iPathConfigFile));

            //ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap { ExeConfigFilename = iPathConfigFile };
            //Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            IUnityContainer container = new UnityContainer();

            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            return container.LoadConfiguration(section, string.Empty);
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
