using System.Collections.Generic;
using EPiServer.Core;
using UnderConstruction.WebPage.Models.Pages;

namespace UnderConstruction.WebPage.Models.ViewModels
{
    public class ListingBlockViewModel
    {
        public string Heading { get; set; }
        public IEnumerable<SitePageData> Pages { get; set; }
    }
}