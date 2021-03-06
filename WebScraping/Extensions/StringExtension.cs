﻿using HtmlAgilityPack;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
            if (s == null)
            {
                return string.Empty;
            }

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(s);
            return htmlDoc.DocumentNode.InnerText;
        }

        public static string RemoveRTN(this string s)
        {
            return Regex.Replace(s, @"\t|\n|\r", "");
        }

        public static string GetOnlyDigits(this string s)
        {
            return new string((from c in s
                               where char.IsDigit(c)
                               select c).ToArray()).Trim();
        }
    }
}
