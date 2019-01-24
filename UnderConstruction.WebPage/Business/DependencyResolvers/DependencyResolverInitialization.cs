using System;
using System.Linq;
using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;
using StructureMap;
using UnderConstruction.WebPage.Business.Rendering;

namespace UnderConstruction.WebPage.Business.DependencyResolvers
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.StructureMap().Configure(ConfigureContainer);
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.StructureMap()));
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            container.For<ContentAreaRenderer>().Use<MyContentAreaRenderer>();
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}