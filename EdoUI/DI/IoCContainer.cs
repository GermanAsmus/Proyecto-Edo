using Dominio;
using Dominio.Entidades.Interfaces;
using Dominio.Persistencia;
using EdoUI;
using EdoUI.Cuenta;
using EdoUI.Mensaje;
using Microsoft.Practices.Unity;
using Persistencia;
using System;

namespace EdoUI.DI
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

            pContainer.RegisterType<BandejaCuenta>(new InjectionFactory(b => new BandejaCuenta()));
            pContainer.RegisterType<BandejaMensaje>(new InjectionFactory(b => new BandejaMensaje()));


        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        } 

    }
}
