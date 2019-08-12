using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebScraping.Services.HTML
{
    public class HTMLNodeService : IHTMLNodeService
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
