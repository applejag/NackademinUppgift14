using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "Single quality", 
        GUID = "ebe8da93-1132-43a7-848a-eba85e34fd2f",
        Description = "",
        AvailableInEditMode = false)]
    public class SingleQuality : BlockData
    {
        [Required]
        [CultureSpecific]
        [Display(Name = "Quality title",
            Order = 10)]
        public virtual string Title { get; set; }

        [Required]
        [CultureSpecific]
        [Display(Name = "Quality description",
            Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        [Required]
        [CultureSpecific]
        [Display(Name = "Quality icon name (font-awesome v3, without \"fa-\")",
            Order = 30)]
        public virtual string Icon { get; set; }
    }
}