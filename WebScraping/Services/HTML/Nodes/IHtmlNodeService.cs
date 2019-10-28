using HtmlAgilityPack;

namespace WebScraping.Services.HTML.Nodes
{
    public interface IHtmlNodeService
    {
        string GetInnerText(HtmlDocument htmlDocument, string xpath);
    }
}
