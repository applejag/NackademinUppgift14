using System;
using System.Web.Mvc;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using UnderConstruction.WebPage.Models.Blocks;
using UnderConstruction.WebPage.Models.ViewModels;

namespace UnderConstruction.WebPage.Controllers
{
    [TemplateDescriptor(Tags = new[] {SiteTags.Full},
        AvailableWithoutTag = true)]
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var model = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodayVisitorCount = new Random().Next(900, 10900)
            };

            return PartialView(model);
        }
    }

    [TemplateDescriptor(Tags = new[] {SiteTags.Wide},
        AvailableWithoutTag = false)]
    public class TeaserBlockWideController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var model = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodayVisitorCount = new Random().Next(900, 10900)
            };

            return PartialView(model);
        }
    }

    [TemplateDescriptor(Tags = new[] {SiteTags.Narrow},
        AvailableWithoutTag = false)]
    public class TeaserBlockNarrowController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var model = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock,
                TodayVisitorCount = new Random().Next(900, 10900)
            };

            return PartialView(model);
        }
    }

}
