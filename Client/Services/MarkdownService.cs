using Markdig;

namespace BlazorApp.Services
{
    public class MarkdownService
    {
        public string ConvertMarkdownToHtml(string markdown)
        {
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdown.ToHtml(markdown, pipeline);
        }
    }
}
