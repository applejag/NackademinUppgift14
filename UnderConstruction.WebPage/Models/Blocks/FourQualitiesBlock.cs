using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using UnderConstruction.WebPage.Models.Media;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "Four qualities",
        GUID = "133a378e-3846-4913-afab-0e98645e2e82",
        Description = "Use this to display four qualities (with images) and short descriptions about each quality.")]
    public class FourQualitiesBlock : BlockData
    {
        public const string QualitiesTab = "4 Qualities";

        [Required]
        [CultureSpecific]
        [Display(Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Content text",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString Description { get; set; }

        [Display(Name = "Quality #1",
            GroupName = QualitiesTab,
            Order = 10)]
        public virtual SingleQuality Quality1 { get; set; }

        [Display(Name = "Quality #2",
            GroupName = QualitiesTab,
            Order = 20)]
        public virtual SingleQuality Quality2 { get; set; }

        [Display(Name = "Quality #3",
            GroupName = QualitiesTab,
            Order = 30)]
        public virtual SingleQuality Quality3 { get; set; }

        [Display(Name = "Quality #4",
            GroupName = QualitiesTab,
            Order = 40)]
        public virtual SingleQuality Quality4 { get; set; }
    }
}