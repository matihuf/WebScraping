using HtmlAgilityPack;
using System.Linq;

namespace WebScraping.Services.HTML.Nodes
{
    public class HtmlNodeService : IHtmlNodeService
    {
        public string GetInnerText(HtmlDocument htmlDocument, string xpath)
        {
            HtmlNodeCollection htmlNodes = htmlDocument.DocumentNode.SelectNodes(xpath);
            if (htmlNodes != null)
            {
                HtmlNode node = htmlNodes.FirstOrDefault();
                if (node != null)
                {
                    return node.InnerText;
                }
            }
            return string.Empty;
        }
    }
}
