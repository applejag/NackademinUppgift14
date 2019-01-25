using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "Listing",
        GroupName = SiteGroupNames.Common,
        GUID = "f298a01e-5de1-4fb3-8d6d-9ff9d3deee44",
        Description = "Choose a page in the tree, and its children will be listed, with a heading.")]
    public class ListingBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}