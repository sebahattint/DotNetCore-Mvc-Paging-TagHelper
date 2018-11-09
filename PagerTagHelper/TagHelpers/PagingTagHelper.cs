using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace PagerTagHelper.TagHelpers
{
    [HtmlTargetElement("mytags-pager-nav")]
    public class PagingTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder builder = new StringBuilder();
            builder.Append("<ul class='pagination'>");

            for (int i = 1; i <= PageCount; i++)
            {
                builder.AppendFormat("<li class='page-item {0}'>", i == CurrentPage ? "active" : "");
                builder.AppendFormat("<a href='/home/index/{0}' class='page-link'>{0}</a>", i);
                builder.AppendFormat("</li>");
            }

            output.Content.SetHtmlContent(builder.ToString());

            base.Process(context, output);
        }
    }
}
