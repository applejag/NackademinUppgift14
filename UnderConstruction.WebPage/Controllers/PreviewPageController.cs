using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using UnderConstruction.WebPage.Models.Pages;
using UnderConstruction.WebPage.Models.ViewModels;

namespace UnderConstruction.WebPage.Controllers
{
    [TemplateDescriptor(Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        AvailableWithoutTag = false)]
    public class PreviewPageController : ActionControllerBase, IRenderTemplate<BlockData>
    {
        private readonly IContentLoader _loader;

        public PreviewPageController(IContentLoader loader)
        {
            _loader = loader;
        }

        public ActionResult Index(IContent currentContent)
        {
            var startPage = _loader.Get<StartPage>(ContentReference.StartPage);
            var model = new PreviewPageViewModel(startPage, currentContent);
            return View(model);
        }
    }
}