using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "Teaser",
        GUID = "ee0a9da0-534d-4c1e-a22f-abdf6ffaa767",
        Description = "Use this for rich text with heading, image and page link that will be reused in multiple places")]
    public class TeaserBlock : BlockData
    {
        [Display(Name = "Heading",
            GroupName = SystemTabNames.PageHeader,
            Order = 10)]
        [CultureSpecific]
        public virtual string TeaserHeading { get; set; }

        [Display(Name = "Rich text",
            Order = 20)]
        [CultureSpecific]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(Name = "Thumbnail image",
            GroupName = SystemTabNames.PageHeader,
            Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(Name = "Link",
            GroupName = SystemTabNames.PageHeader,
            Order = 40)]
        public virtual PageReference TeaserLink { get; set; }
    }
}