using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebScraping.Services.HTML
{
    public interface IHtmlNodeService
    {
        string GetInnerText(HtmlDocument htmlDocument, string xpath);
    }
}
