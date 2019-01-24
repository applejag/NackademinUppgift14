using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "CarouselItemBlock",
        GUID = "a2d34a78-31c9-4584-9c54-936803ca6ec5",
        Description = "",
        AvailableInEditMode = false)]
    public class CarouselItemBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Small header",
            Order = 10)]
        public virtual string SmallHeader { get; set; }

        [Required]
        [Display(Name = "Background image",
            Order = 15)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackgroundImage { get; set; }

        [Required]
        [Display(Name = "Big header",
            Order = 20)]
        public virtual string BigHeader1 { get; set; }

        [Display(Name = "Big header 2",
            Order = 30)]
        public virtual string BigHeader2 { get; set; }

        [Required]
        [Display(Name = "Paragraph",
            Order = 40)]
        public virtual XhtmlString Paragraph { get; set; }

        [Display(Name = "Links",
            Order = 50)]
        public virtual LinkItemCollection Links { get; set; }
    }
}