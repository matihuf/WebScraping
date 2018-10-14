using HtmlAgilityPack;
using System.Text;

namespace WebScraping.Extensions
{
    public static class StringExtension
    {
        public static string RemoveDiacritics(this string s)
        {
            return Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(s));
        }

        public static string RemoveHtmlTags(this string s)
        {
            if(s == null)
            {
                return string.Empty;
            }

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(s);
            return htmlDoc.DocumentNode.InnerText;
        }
    }
}
