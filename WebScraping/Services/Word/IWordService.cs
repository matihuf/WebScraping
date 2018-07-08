using System.Collections.Generic;

namespace WebScraping.Services.Words
{
    public interface IWordService
    {
        bool AreWordsExists(string text, IEnumerable<string> words);
        bool IsDigit(string text);
        bool IsWordExists(string text, string word);
    }
}
