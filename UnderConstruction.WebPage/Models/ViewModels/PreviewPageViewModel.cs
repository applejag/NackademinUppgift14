using EPiServer.Core;
using UnderConstruction.WebPage.Models.Pages;

namespace UnderConstruction.WebPage.Models.ViewModels
{
    public class PreviewPageViewModel : PageViewModel<SitePageData>
    {
        public ContentArea PreviewArea { get; set; }

        public PreviewPageViewModel(SitePageData currentPage, IContent contentToPreview)
            : base(currentPage)
        {
            PreviewArea = new ContentArea();
            PreviewArea.Items.Add(new ContentAreaItem { ContentLink = contentToPreview.ContentLink });
        }
    }
}