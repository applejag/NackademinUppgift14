using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "CarouselBlock", 
        GUID = "778225b0-fe7c-405c-9a78-9700a3184cc5", 
        Description = "")]
    public class CarouselBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Carousel items")]
        [AllowedTypes(typeof(CarouselItemBlock))]
        public virtual ContentArea CarouselItems { get; set; }
    }
}