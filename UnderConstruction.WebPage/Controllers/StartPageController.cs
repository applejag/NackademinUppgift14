using System.Web.Mvc;
using EPiServer;
using EPiServer.Web.Mvc;
using UnderConstruction.WebPage.Models.Pages;

namespace UnderConstruction.WebPage.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public StartPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(StartPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}