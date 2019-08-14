using System;
using System.Collections.Generic;
using System.Text;

namespace WebScraping.Services.Url
{
    public interface IUrlChecker
    {
        Tuple<bool, Uri> GetWithValid(string url);
    }
}
