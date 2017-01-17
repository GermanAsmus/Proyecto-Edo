using Dominio;
using Dominio.Persistencia;
using Microsoft.Practices.Unity;
using Persistencia;
using System;

namespace EdoUi.DI
{
    public class IoCContainer
    {
        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        private static IUnityContainer Container
        {
            get { return cInstance.Value; }
        }

        private static void RegisterTypes(IUnityContainer pContainer)
        {
            pContainer.RegisterType<IControladorDominio, ControladorDominio>();
            pContainer.RegisterType<IControladorPersistencia, ControladorPersistencia>();
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        } 

    }
}
