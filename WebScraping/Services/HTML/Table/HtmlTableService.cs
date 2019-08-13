using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace WebScraping.Services.HTML.Table
{
    public class HtmlTableService : IHtmlTableService
    {
        public IEnumerable<HtmlNode> GetTrNodes(HtmlDocument htmlDocument, string xpath)
        {
            if (htmlDocument != null && htmlDocument.DocumentNode != null)
            {
                return htmlDocument.DocumentNode.SelectNodes(xpath).Elements("tr");
            }
            return new List<HtmlNode>();
        }

        public HtmlNode GetThNode(HtmlNode trNode)
        {
            return trNode.ChildNodes.FirstOrDefault(x => x.Name.Equals("th"));
        }

        public HtmlNode GetTdNode(HtmlNode trNode)
        {
            return trNode.ChildNodes.FirstOrDefault(x => x.Name.Equals("td"));
        }
    }
}
