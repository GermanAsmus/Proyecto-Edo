﻿using EdoUI;
using EdoUI.UICuenta;
using EdoUI.Mensaje;
using Microsoft.Practices.Unity;
using System;

namespace EdoUI.DI
{
    public class IoCContainer
    {
        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            return container;
        });

        private static IUnityContainer Container
        {
            get { return cInstance.Value; }
        }

        public static void RegisterType<TFrom, TTo>(IUnityContainer pContainer)
        {
            Container.RegisterType<TFrom>(new InjectionFactory(r => Activator.CreateInstance<TTo>()));
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        } 

    }
}
