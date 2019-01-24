using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;

namespace UnderConstruction.WebPage.Business.Rendering
{
    public class MyContentAreaRenderer : ContentAreaRenderer
    {
        private readonly IContentAreaLoader _contentAreaLoader;
        private readonly IContentRenderer _contentRenderer;
        private readonly IContentAreaItemAttributeAssembler _attributeAssembler;

        public MyContentAreaRenderer(
            IContentAreaLoader contentAreaLoader,
            IContentRenderer contentRenderer,
            IContentAreaItemAttributeAssembler attributeAssembler)
        {
            _contentAreaLoader = contentAreaLoader;
            _contentRenderer = contentRenderer;
            _attributeAssembler = attributeAssembler;
        }

        protected override void RenderContentAreaItem(
            HtmlHelper htmlHelper,
            ContentAreaItem contentAreaItem,
            string templateTag,
            string htmlTag,
            string cssClass)
        {
            var renderSettings = new Dictionary<string, object>
            {
                ["childrencustomtagname"] = htmlTag,
                ["childrencssclass"] = cssClass,
                ["tag"] = templateTag
            };

            renderSettings = contentAreaItem.RenderSettings.Concat(
                from r in renderSettings
                where !contentAreaItem.RenderSettings.ContainsKey(r.Key)
                select r).ToDictionary(r => r.Key, r => r.Value);

            htmlHelper.ViewBag.RenderSettings = renderSettings;
            var content = _contentAreaLoader.Get(contentAreaItem);
            if (content == null)
            {
                return;
            }

            bool isInEditMode = IsInEditMode(htmlHelper);

            using (new ContentAreaContext(htmlHelper.ViewContext.RequestContext, content.ContentLink))
            {
                var templateModel = ResolveTemplate(htmlHelper, content, templateTag);
                if (templateModel != null || isInEditMode)
                {
                    bool renderWrappingElement = ShouldRenderWrappingElementForContentAreaItem(htmlHelper);

                    // The code for this method has been c/p from EPiServer.Web.Mvc.Html.ContentAreaRenderer.
                    // The only difference is this if/else block.
                    if (isInEditMode || renderWrappingElement)
                    {
                        var tagBuilder = new TagBuilder(htmlTag);
                        AddNonEmptyCssClass(tagBuilder, cssClass);
                        tagBuilder.MergeAttributes(_attributeAssembler.GetAttributes(
                            contentAreaItem,
                            isInEditMode,
                            templateModel != null));
                        BeforeRenderContentAreaItemStartTag(tagBuilder, contentAreaItem);
                        htmlHelper.ViewContext.Writer.Write(tagBuilder.ToString(TagRenderMode.StartTag));
                        htmlHelper.RenderContentData(content, true, templateModel, _contentRenderer);
                        htmlHelper.ViewContext.Writer.Write(tagBuilder.ToString(TagRenderMode.EndTag));
                    }
                    else
                    {
                        // This is the extra code: don't render wrapping elements in view mode
                        htmlHelper.RenderContentData(content, true, templateModel, _contentRenderer);
                    }
                }
            }
        }

        private bool ShouldRenderWrappingElementForContentAreaItem(HtmlHelper htmlHelper)
        {
            // set 'haschildcontainers' to false by default
            bool? item = (bool?)htmlHelper.ViewContext.ViewData["haschildcontainers"];
            return item.HasValue && item.Value;
        }

        protected override bool ShouldRenderWrappingElement(HtmlHelper htmlHelper)
        {
            // set 'hascontainer' to false by default
            bool? item = (bool?)htmlHelper.ViewContext.ViewData["hascontainer"];
            return item.HasValue && item.Value;
        }
    }
}