using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace UnderConstruction.WebPage.Models.Media
{
    [ContentType(DisplayName = "SVG file",
        GUID = "45031716-a1e5-4795-bb5b-e96123340e52",
        Description = "Use this to upload Scalable Vector Graphic(SVG) images.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {
        // instead of generating a smaller bitmap file for thumbnail,
        // use the same binary vector image for thumbnail
        public override Blob Thumbnail => BinaryData;
    }
}