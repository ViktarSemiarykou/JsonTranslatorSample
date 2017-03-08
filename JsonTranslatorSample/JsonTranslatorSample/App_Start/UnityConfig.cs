using System;
using System.IO;
using System.Web.Mvc;
using JsonTranslatorSample.Data;
using JsonTranslatorSample.Service;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace JsonTranslatorSample
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IDataRepository, DummyJsonDataRepository>(new InjectionConstructor(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Content\Data.json")));
            container.RegisterType<IDataService, DummyJsonDataService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}