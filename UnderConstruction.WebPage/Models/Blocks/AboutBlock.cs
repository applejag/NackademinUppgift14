using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using UnderConstruction.WebPage.Models.Media;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "About section",
        GUID = "3a7bae11-2e24-401b-9eb3-3fc03268f94d",
        Description = "Use this to display a descriptive about section.")]
    public class AboutBlock : BlockData
    {
        [Required]
        [Display(Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Subheading",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Subheading { get; set; }

        [Display(Name = "Content text",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString Content { get; set; }

        [Display(Name = "Background image",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBackground { get; set; }

        [Required]
        [Display(Name = "Foreground image",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageForeground { get; set; }

        [Display(Name = "Links",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual LinkItemCollection Links { get; set; }
    }
}