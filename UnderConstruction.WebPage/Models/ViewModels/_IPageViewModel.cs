using System.Collections.Generic;
using EPiServer.Core;
using UnderConstruction.WebPage.Models.Pages;

namespace UnderConstruction.WebPage.Models.ViewModels
{
    public interface IPageViewModel<T> where T : SitePageData
    {
        T CurrentPage { get; set; }
        IEnumerable<SitePageData> MenuPages { get; set; }
        IContent Section { get; set; }
        StartPage StartPage { get; set; }
    }
}