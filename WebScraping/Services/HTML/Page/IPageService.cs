using System.Collections.Generic;

namespace WebScraping.Services.HTML.Page
{
    public interface IPageService
    {
        int GetPageCount(string xpath);
        IEnumerable<string> GetPageUrls(int pageCount);
    }
}
