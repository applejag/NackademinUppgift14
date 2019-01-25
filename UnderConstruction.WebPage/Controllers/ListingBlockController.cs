using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web.Mvc;
using UnderConstruction.WebPage.Models.Blocks;
using UnderConstruction.WebPage.Models.Pages;
using UnderConstruction.WebPage.Models.ViewModels;

namespace UnderConstruction.WebPage.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        private readonly IContentLoader _loader;

        public ListingBlockController(IContentLoader loader)
        {
            _loader = loader;
        }

        public override ActionResult Index(ListingBlock currentBlock)
        {
            var viewModel = new ListingBlockViewModel
            {
                Heading = currentBlock.Heading
            };

            if (currentBlock.ShowChildrenOfThisPage != null)
            {
                IEnumerable<SitePageData> allChildren = _loader.GetChildren<SitePageData>(currentBlock.ShowChildrenOfThisPage);
                IEnumerable<IContent> filteredChildren = FilterForVisitor.Filter(allChildren);

                viewModel.Pages = filteredChildren.Cast<SitePageData>()
                    .Where(p => p.VisibleInMenu);
            }

            return PartialView(viewModel);
        }
    }
}
