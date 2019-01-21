using System.Web.Optimization;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace UnderConstruction.WebPage.Business.Initialization
{
    [InitializableModule]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JS
            Bundle scripts = new ScriptBundle("~/Bundles/js")
                // LibMan added
                .Include("~/Static/libs/jquery/jquery.js")
                .Include("~/Static/libs/bootstrap/js/bootstrap.js")
                .Include("~/Static/libs/jquery.isotope/isotope.pkgd.js")
                .Include("~/Static/libs/jquery.fancybox/jquery.fancybox.js")
                .Include("~/Static/libs/jquery.scrollup/jquery.scrollUp.js")
                // Custom
                .Include("~/Static/js/bootsnav.js")
                .Include("~/Static/js/isotope-active.js")
                .Include("~/Static/js/main.js");

            bundles.Add(scripts);

            // CSS
            Bundle styles = new StyleBundle("~/Bundles/css")
                // LibMan added
                .Include("~/Static/libs/bootstrap/css/bootstrap.css", new CssRewriteUrlTransform())
                .Include("~/Static/libs/font-awesome/css/font-awesome.css", new CssRewriteUrlTransform())
                .Include("~/Static/libs/jquery.fancybox/jquery.fancybox.css", new CssRewriteUrlTransform())
                // Custom
                .Include("~/Static/css/fonts.css", new CssRewriteUrlTransform())
                .Include("~/Static/css/bootsnav.css", new CssRewriteUrlTransform())
                .Include("~/Static/css/custom.css", new CssRewriteUrlTransform());

            bundles.Add(styles);

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}
