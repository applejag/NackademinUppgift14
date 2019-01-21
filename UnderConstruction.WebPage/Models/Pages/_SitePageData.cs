using System.ComponentModel.DataAnnotations;
using AlloyTraining;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace UnderConstruction.WebPage.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [Display(Name = "Meta title",
            GroupName = SiteTabNames.SEO,
            Order = 100)]
        [StringLength(60, MinimumLength = 5)]
        [CultureSpecific]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "Meta keywords",
            GroupName = SiteTabNames.SEO,
            Order = 200)]
        [CultureSpecific]
        public virtual string MetaKeywords { get; set; }

        [Display(Name = "Meta description",
            GroupName = SiteTabNames.SEO,
            Order = 300)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "Page thumbnail image",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }
    }
}