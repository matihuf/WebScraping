using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace WebScraping.Services.HTML.Page
{
    public class PageService : IPageService
    {
        private IHTMLService htmlService;
        private const int SKIP_NEXT_BUTTON_INDEX = 2;
        protected string url;

        public PageService(IHTMLService htmlService, string url)
        {
            this.htmlService = htmlService;
            this.url = url;
        }

        public int GetPageCount(string xpath)
        {
            HtmlDocument htmlDocument = this.htmlService.GetHtmlDocument(this.url).Result;

            int page = 0;
            HtmlNodeCollection nodes = htmlDocument.DocumentNode.SelectNodes(xpath);
            if (nodes == null)
            {
                throw new NullReferenceException("The XPath does not return results.");
            }

            HtmlNode last = nodes.Last();
            if (Int32.TryParse(last.InnerText, out page))
            {
                return page;
            }
            else
            {
                HtmlNode l = nodes[nodes.Count - SKIP_NEXT_BUTTON_INDEX];
                Int32.TryParse(l.InnerText, out page);
            }

            return page;
        }

        public IEnumerable<string> GetPageUrls(int pageCount, string pageWord, int startIndex = 1)
        {
            if (pageCount == 0)
            {
                yield return this.url;
            }
            else
            {
                for (int i = startIndex; i <= pageCount; i++)
                {
                    yield return this.url + pageWord + i;
                }
            }
        }
    }
}
