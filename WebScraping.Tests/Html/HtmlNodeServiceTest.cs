using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebScraping.Services.HTML.Nodes;
using WebScraping.Tests.HtmlData;

namespace WebScraping.Tests.Html
{
    [TestClass]
    public class HtmlNodeServiceTest
    {
        private readonly HtmlNodeService htmlNodeService;
        private static HtmlDocument document;

        public HtmlNodeServiceTest()
        {
            this.htmlNodeService = new HtmlNodeService();
        }

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            document = new HtmlDocument();
            document.LoadHtml(Reader.ReadHtml(@"HtmlData\table.html"));
        }

        [TestMethod]
        public void GetInnerText_NodeNotExists_Empty()
        {
            string expected = string.Empty;
            string nodeXpath = "//div/h2";

            string innerText = htmlNodeService.GetInnerText(document, nodeXpath);

            Assert.AreEqual(expected, innerText);
        }

        [TestMethod]
        public void GetInnerText_NodeExists_ReturnText()
        {
            string expected = "Table";
            string nodeXpath = "//h2";

            string innerText = htmlNodeService.GetInnerText(document, nodeXpath);

            Assert.AreEqual(expected, innerText);
        }
    }
}