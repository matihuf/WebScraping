using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using WebScraping.Services.HTML;
using WebScraping.Services.Http;

namespace WebScraping
{
    public class WebScrapingService : IWebScrapingService
    {
        private readonly IHTMLService hTMLService;
        private readonly IHTMLNodeService hTMLNodeService;

        public WebScrapingService(IHttpService httpService)
        {
            hTMLService = new HTMLService(httpService);
            hTMLNodeService = new HTMLNodeService();
        }

        public async Task<HtmlDocument> GetHtmlDocument(string url)
        {
            return await hTMLService.GetHtmlDocument(url);
        }

        public string GetInnerText(HtmlDocument htmlDocument, string xpath)
        {
            return hTMLNodeService.GetInnerText(htmlDocument, xpath);
        }
    }
}
