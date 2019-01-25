using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace UnderConstruction.WebPage.Models.Blocks
{
    [ContentType(DisplayName = "Contact info",
        GUID = "a2cce5a2-74f1-438a-b14f-dde51f35b696",
        AvailableInEditMode = false)]
    public class ContactBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Name",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [DataType(DataType.EmailAddress)]
        public virtual string Email { get; set; }

        [CultureSpecific]
        [Display(Name = "Location",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Location { get; set; }

        [CultureSpecific]
        [Display(Name = "Phone number",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [DataType(DataType.PhoneNumber)]
        public virtual string Phone { get; set; }

        [CultureSpecific]
        [Display(Name = "Phone open hours",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string OpeningHours { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            OpeningHours = "Mon - Sat 9:00 - 19:00";
        }
    }
}