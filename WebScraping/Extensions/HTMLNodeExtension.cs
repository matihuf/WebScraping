using HtmlAgilityPack;
using System;

namespace WebScraping.Extensions
{
    public static class HtmlNodeExtension
    {
        public static string GetStringValue(this HtmlNode htmlNode, string xpath)
        {
            if(string.IsNullOrEmpty(xpath))
            {
                return string.Empty;
            }

            HtmlNode node = htmlNode.SelectSingleNode(xpath);
            if (node == null)
            {
                return string.Empty;
            }

            return node.InnerText;
        }

        public static DateTime GetDateTimeValue(this HtmlNode htmlNode, string xpath)
        {
            if (string.IsNullOrEmpty(xpath))
            {
                return DateTime.MinValue;
            }

            HtmlNode node = htmlNode.SelectSingleNode(xpath);
            if (node != null && DateTime.TryParse(node.InnerText, out DateTime dateTime))
            {
                return dateTime;
            }
            return DateTime.MinValue;
        }

        public static string GetExtAttributeValue(this HtmlNode htmlNode, string xpath, string attribute)
        {
            if (string.IsNullOrEmpty(xpath) || string.IsNullOrEmpty(attribute))
            {
                return string.Empty;
            }

            HtmlNode node = htmlNode.SelectSingleNode(xpath);
            if (node == null)
            {
                return string.Empty;
            }

            return node.GetAttributeValue(attribute, string.Empty);
        }
    }
}
