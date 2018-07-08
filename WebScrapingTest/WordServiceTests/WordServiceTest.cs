using NUnit.Framework;
using WebScraping.Services.Words;

namespace WebScrapingTest.WordServiceTests
{
    [TestFixture]
    public class WordServiceTest
    {
        private readonly IWordService wordService;

        public WordServiceTest()
        {
            this.wordService = new WordService();
        }

        [Test]
        [TestCase("number", TestName = "{m}_ShouldReturnFalse_ForText", ExpectedResult = false)]
        [TestCase("1", TestName = "{m}_ShouldReturnTrue_ForNumber", ExpectedResult = true)]
        public bool IsDigit(string text)
        {
           return this.wordService.IsDigit(text);
        }

        [Test]
        [TestCase("words", "there is no word that expect", TestName = "{m}_ShouldReturnFalse_IfNotFound", ExpectedResult = false)]
        [TestCase("words", "there are words that expect", TestName = "{m}_ShouldReturnTrue_IfFound", ExpectedResult = true)]
        public bool IsWordExists(string word, string text)
        {
            return this.wordService.IsWordExists(text, word);
        }

        [Test]
        [TestCase("there is nothing about animals", new string[] { "horse", "cow" },
            TestName = "{m}_ShouldReturnFalse_IfNotFoundAll", ExpectedResult = false)]
        [TestCase("there is a horse and a cow", new string[] {"horse", "cow"},
             TestName = "{m}_ShouldReturnTrue_IfFoundAll", ExpectedResult = true)]
        [TestCase("there is only a cow", new string[] { "horse", "cow" },
             TestName = "{m}_ShouldReturnFalse_IfFoundOneOfTwo", ExpectedResult = false)]
        public bool AreWordsExists(string text, string[] requiredWords)
        {
            return this.wordService.AreWordsExists(text, requiredWords);
        }
    }
}
