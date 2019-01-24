using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "Content area",
        GUID = "ad4abd7b-518a-4767-991f-54e0688d2fe2",
        Description = "Use this for a collection of contents in it's content area.")]
    public class ContentAreaBlock : BlockData
    {
        [Display(Name = "Heading",
            GroupName = SystemTabNames.PageHeader,
            Order = 10)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(Name = "Content area",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentArea ContentArea { get; set; }
    }
}