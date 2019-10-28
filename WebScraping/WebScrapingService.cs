using System.Threading.Tasks;
using HtmlAgilityPack;
using WebScraping.Services.HTML;
using WebScraping.Services.HTML.Nodes;

namespace WebScraping
{
    public class WebScrapingService : IWebScrapingService
    {
        private readonly IHtmlServie hTMLService;
        private readonly IHtmlNodeService hTMLNodeService;

        public WebScrapingService(IHtmlServie hTMLService, IHtmlNodeService hTMLNodeService)
        {
            this.hTMLService = hTMLService;
            this.hTMLNodeService = hTMLNodeService;
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
