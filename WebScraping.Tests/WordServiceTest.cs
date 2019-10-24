using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebScraping.Services.Words;

namespace WebScraping.Tests
{
    [TestClass]
    public class WordServiceTest
    {
        private readonly IWordService wordService;

        public WordServiceTest()
        {
            wordService = new WordService();
        }

        [TestMethod]
        public void IsDigit_Text_False()
        {
            bool expected = false;
            string text = "test text";

            bool isDigit = this.wordService.IsDigit(text);

            Assert.AreEqual(expected, isDigit);
        }

        [TestMethod]
        public void IsDigit_Digit_True()
        {
            bool expected = true;
            string digit = "10";

            bool isDigit = this.wordService.IsDigit(digit);

            Assert.AreEqual(expected, isDigit);
        }

        [TestMethod]
        public void IsWordExists_Exists_True()
        {
            bool expected = true;
            string word = "yes";
            string text = "there is yes in text";

            bool isWordExists = this.wordService.IsWordExists(text, word);

            Assert.AreEqual(expected, isWordExists);
        }

        [TestMethod]
        public void IsWordExists_NotExists_False()
        {
            bool expected = false;
            string word = "no";
            string text = "there is yes in text";

            bool isWordExists = this.wordService.IsWordExists(text, word);

            Assert.AreEqual(expected, isWordExists);
        }

        [TestMethod]
        public void AreWordsExists_Exists_True()
        {
            bool expected = true;
            string[] words = new string[] { "yes", "no" };
            string text = "there is yes and no";

            bool areWordsExists = this.wordService.AreWordsExists(text, words);

            Assert.AreEqual(expected, areWordsExists);
        }

        [TestMethod]
        public void AreWordsExists_NotExists_False()
        {
            bool expected = false;
            string[] words = new string[] { "cat", "dog" };
            string text = "there is yes and no";

            bool areWordsExists = this.wordService.AreWordsExists(text, words);

            Assert.AreEqual(expected, areWordsExists);
        }

        [TestMethod]
        public void AreWordsExists_OneExists_False()
        {
            bool expected = false;
            string[] words = new string[] { "yes", "dog" };
            string text = "there is yes and no";

            bool areWordsExists = this.wordService.AreWordsExists(text, words);

            Assert.AreEqual(expected, areWordsExists);
        }
    }
}
