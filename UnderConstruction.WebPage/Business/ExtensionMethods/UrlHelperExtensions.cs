using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace UnderConstruction.WebPage.Business.ExtensionMethods
{
    public static class UrlHelperExtensions
    {
        public static string Action(this UrlHelper url, ContentReference contentLink, string action = "index")
        {
            var resolver = ServiceLocator.Current.GetInstance<UrlResolver>();

            return resolver.GetUrl(contentLink, null, new VirtualPathArguments
            {
                Action = action
            });
        }
    }
}