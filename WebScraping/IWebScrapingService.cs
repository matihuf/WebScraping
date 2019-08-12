using System;
using System.Collections.Generic;
using System.Text;
using WebScraping.Services.HTML;

namespace WebScraping
{
    public interface IWebScrapingService : IHTMLService, IHTMLNodeService
    {
    }
}
