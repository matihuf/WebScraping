using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WebScraping.Services.Words
{
    public class WordService : IWordService
    {
        public bool AreWordsExists(string text, IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                if (!IsWordExists(text, word))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsWordExists(string text, string word)
        {
            return Regex.Match(text, string.Format(@"\b{0}\b", word), RegexOptions.Singleline | RegexOptions.IgnoreCase).Success;
        }

        public bool IsDigit(string text)
        {
            return Regex.Match(text, @"\d+").Success;
        }
    }
}
