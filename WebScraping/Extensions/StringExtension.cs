using System.Text;

namespace WebScraping.Extensions
{
    public static class StringExtension
    {
        public static string RemoveDiacritics(this string s)
        {
            return Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(s));
        }
    }
}
