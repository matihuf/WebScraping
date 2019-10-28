using HtmlAgilityPack;
using System.Collections.Generic;

namespace WebScraping.Services.HTML.Table
{
    public interface IHtmlTableService
    {
        IEnumerable<HtmlNode> GetTrNodes(HtmlDocument htmlDocument, string tableXpath);
        HtmlNode GetThNode(HtmlNode trNode);
        HtmlNode GetTdNode(HtmlNode trNode);
    }
}