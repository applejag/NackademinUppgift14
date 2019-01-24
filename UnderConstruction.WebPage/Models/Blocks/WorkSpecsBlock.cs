using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "Work Specifications",
        GUID = "b7e51658-50f9-4aca-b962-18d5f855a538",
        Description = "Descriptive specifications for a service the company provides.")]
    public class WorkSpecsBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name of service",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string ServiceName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Starting price",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual int CostStarting { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Monthly cost",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual int CostMonthly { get; set; }

    }
}