using System;
using System.Collections.Generic;
using System.Text;

namespace WebScraping.Services.Url
{
    public class UrlChecker : IUrlChecker
    {
        public Tuple<bool, Uri> GetWithValid(string url)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return Tuple.Create<bool, Uri>(result, uriResult);
        }
    }
}
