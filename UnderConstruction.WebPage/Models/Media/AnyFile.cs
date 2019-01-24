using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace UnderConstruction.WebPage.Models.Media
{
    [ContentType(DisplayName = "Any File",
        GUID = "39d7412c-8dff-4a72-b878-3279f94c8c23",
        Description = "Use this to upload a file of any type.")]
    public class AnyFile : MediaData
    {
    }
}