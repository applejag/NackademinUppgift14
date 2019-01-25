using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using UnderConstruction.WebPage.Models.Blocks;

namespace UnderConstruction.WebPage.Models.Pages
{
    [ContentType(DisplayName = "Start",
        GroupName = SiteGroupNames.Specialized, Order = 10,
        GUID = "0b3b2063-1cbd-4fd5-bd52-7dc3eed4371c",
        Description = "The home page for a website with an area for blocks and partial pages.")]
    //[SitePageIcon]
    //[AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main Content Area",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        //[AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }


        [CultureSpecific]
        [Display(Name = "Company name",
            Description = "The name of the company. Used in header, title and footer.",
            GroupName = SiteTabNames.SiteSettings, Order = 10)]
        public virtual string CompanyName { get; set; }

        [CultureSpecific]
        [Display(Name = "Company tagline",
            Description = "Tagline/slogan used in the header.",
            GroupName = SiteTabNames.SiteSettings, Order = 20)]
        public virtual string CompanyTagline { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer: About company title",
            GroupName = SiteTabNames.SiteSettings, Order = 50)]
        public virtual string FooterAboutTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer: About company description",
            GroupName = SiteTabNames.SiteSettings, Order = 51)]
        [UIHint(UIHint.Textarea)]
        public virtual string FooterAboutDescription { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer: explore links title",
            GroupName = SiteTabNames.SiteSettings, Order = 60)]
        public virtual string FooterExploreTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer: explore links",
            GroupName = SiteTabNames.SiteSettings, Order = 61)]
        public virtual LinkItemCollection FooterExploreLinks { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer: latest posts title",
            GroupName = SiteTabNames.SiteSettings, Order = 70)]
        public virtual string FooterLatestTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer: contact us title",
            GroupName = SiteTabNames.SiteSettings, Order = 80)]
        public virtual string FooterContactTitle { get; set; }

        [Display(Name = "Contact us details",
            GroupName = SiteTabNames.SiteSettings, Order = 90)]
        public virtual ContactBlock FooterContact { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            CompanyName = "Under Construction";
            CompanyTagline = "Take a break. Have some construction.";
            FooterAboutTitle = "About Company";
            FooterExploreTitle = "Explore links";
            FooterLatestTitle = "Latest posts";
            FooterContactTitle = "Contact us";
        }
    }
}