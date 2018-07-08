using HtmlAgilityPack;
using WebScraping.Services.Http;
using System.Threading.Tasks;

namespace WebScraping.Services.HTML
{
    public class HTMLService : IHTMLService
    {
        private IHttpService httpService;

        public HTMLService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<HtmlDocument> GetHtmlDocument(string url)
        {
            HtmlDocument htmlDocument = new HtmlDocument();

            string html = await httpService.GetResponse(url);
            htmlDocument.LoadHtml(html);

            return htmlDocument;
        }
    }
}
