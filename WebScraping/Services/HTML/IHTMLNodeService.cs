using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebScraping.Services.HTML
{
    public interface IHTMLNodeService
    {
        string GetInnerText(HtmlDocument htmlDocument, string xpath);
    }
}
