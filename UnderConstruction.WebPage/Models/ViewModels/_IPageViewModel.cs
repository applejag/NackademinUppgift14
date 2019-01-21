using System.Collections.Generic;
using EPiServer.Core;
using UnderConstruction.WebPage.Models.Pages;

namespace UnderConstruction.WebPage.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        IEnumerable<SitePageData> MenuPages { get; }
        IContent Section { get; }
        StartPage StartPage { get; }
    }
}