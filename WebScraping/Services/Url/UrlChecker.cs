using System;

namespace WebScraping.Services.Url
{
    public class UrlChecker : IUrlChecker
    {
        public Uri AbsoluteUri {get; private set;}
        public bool IsValid(string url)
        {
            Uri uriResult;
            bool isValid = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        
            if(isValid)
            {
                AbsoluteUri = uriResult;
            }
            return isValid;
        }
    }
}
