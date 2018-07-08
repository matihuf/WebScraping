using HtmlAgilityPack;
using System.Threading.Tasks;

namespace WebScraping.Services.HTML
{
    public interface IHTMLService
    {
        Task<HtmlDocument> GetHtmlDocument(string url);
    }
}
