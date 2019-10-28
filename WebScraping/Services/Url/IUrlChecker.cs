using System;

namespace WebScraping.Services.Url
{
    public interface IUrlChecker
    {
        Uri AbsoluteUri { get; }
        bool IsValid(string url);
    }
}
