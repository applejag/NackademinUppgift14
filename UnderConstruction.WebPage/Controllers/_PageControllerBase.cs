using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web.Mvc;
using UnderConstruction.WebPage.Business.ExtensionMethods;
using UnderConstruction.WebPage.Models.Pages;
using UnderConstruction.WebPage.Models.ViewModels;

namespace UnderConstruction.WebPage.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader Loader;

        protected PageControllerBase(IContentLoader loader)
        {
            Loader = loader;
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(
            TPage currentPage) where TPage : SitePageData
        {
            PageViewModel<TPage> viewmodel = PageViewModel.Create(currentPage);

            viewmodel.StartPage = Loader.Get<StartPage>(ContentReference.StartPage);
            viewmodel.MenuPages = FilterForVisitor
                .Filter(Loader.GetChildren<SitePageData>(ContentReference.StartPage))
                .Cast<SitePageData>()
                .Where(page => page.VisibleInMenu);

            return viewmodel;
        }

    }
}