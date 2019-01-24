using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;
using UnderConstruction.WebPage.Models.Blocks;

namespace UnderConstruction.WebPage.Models.Pages
{
    [ContentType(DisplayName = "Service",
        GUID = "4749a72f-7ac3-40f7-b6ba-16ca3550563a",
        Description = "Use this to describe services the company provides.")]
    public class ServicePage : StandardPage
    {
        public const string WorkSpecsTab = "Work specs";

        [Display(Name = "Work specifications",
            GroupName = WorkSpecsTab,
            Order = 100)]
        public virtual WorkSpecsBlock WorkSpecs { get; set; }
    }
}