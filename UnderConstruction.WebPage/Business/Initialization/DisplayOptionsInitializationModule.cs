using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Web;

namespace UnderConstruction.WebPage.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DisplayOptionsInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var options = context.Locate.Advanced.GetInstance<DisplayOptions>();

            options
                .Add(id: SiteTags.Full, name: "/displayoptions/" + SiteTags.Full, tag: SiteTags.Full,
                    description: "", iconClass: "epi-icon__layout--full")
                .Add(id: SiteTags.Wide, name: "/displayoptions/" + SiteTags.Wide, tag: SiteTags.Wide,
                    description: "", iconClass: "epi-icon__layout--two-thirds")
                .Add(id: SiteTags.Narrow, name: "/displayoptions/" + SiteTags.Narrow, tag: SiteTags.Narrow,
                    description: "", iconClass: "epi-icon__layout--third");
        }

        public void Uninitialize(InitializationEngine context)
        { }
    }
}