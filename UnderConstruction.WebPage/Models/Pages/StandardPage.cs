using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace UnderConstruction.WebPage.Models.Pages
{
    [ContentType(DisplayName = "Standard",
        GUID = "6f437a1e-661f-48ed-abb2-b42f5e808254",
        Description = "Use this page type unless you need a more specialized one.",
        GroupName = SiteGroupNames.Common)]
    [AvailableContentTypes(
        Include = new[] { typeof(StandardPage) })]
        //Exclude = new[] { typeof(ProductPage) }
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Primary heading on the page. If the heading is not set, it will fallback to using it's name instead.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main content area",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 160)]
        public virtual ContentArea MainContentArea { get; set; }

    }
}