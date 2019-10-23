using HtmlAgilityPack;
using System.Threading.Tasks;

namespace WebScraping.Services.HTML
{
    public interface IHtmlServie
    {
        Task<HtmlDocument> GetHtmlDocument(string url);
    }
}
