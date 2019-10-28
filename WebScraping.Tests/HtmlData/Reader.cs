using System.IO;

namespace WebScraping.Tests.HtmlData
{
    public static class Reader
    {
        public static string ReadHtml(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}