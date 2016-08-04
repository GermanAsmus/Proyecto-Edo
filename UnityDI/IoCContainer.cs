﻿using Microsoft.Practices.Unity;
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
