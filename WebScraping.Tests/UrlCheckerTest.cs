using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebScraping.Services.Url;

namespace WebScraping.Tests
{
    [TestClass]
    public class UrlCheckerTest
    {
        private IUrlChecker urlChecker;

        public UrlCheckerTest()
        {
            this.urlChecker = new UrlChecker();    
        }

        [TestMethod]
        public void IsValid_Valid_True()
        {
            string url = "https://test.test";
            bool expected = true;

            bool isValid = urlChecker.IsValid(url);

            Assert.AreEqual(expected, isValid);
        }

        [TestMethod]
        public void IsValid_NotValid_False()
        {
            string url = "www.wp.pl";
            bool expected = false;

            bool isValid = urlChecker.IsValid(url);

            Assert.AreEqual(expected, isValid);
        }
    }
}