using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebScraping.Services.HTML.Table;
using WebScraping.Tests.HtmlData;

namespace WebScraping.Tests.Html
{
    [TestClass]
    public class TableServiceTest
    {
        private IHtmlTableService htmlTableService;

        public TableServiceTest()
        {
            htmlTableService = new HtmlTableService();
        }

        [TestMethod]
        public void GetTrNodes_Exists3_Resturn3()
        {
            int expected = 3;
            string tableXpath = "//table";
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(Reader.ReadHtml(@"HtmlData\table.html"));

            IEnumerable<HtmlNode> nodes = htmlTableService.GetTrNodes(document, tableXpath);

            Assert.AreEqual(expected, nodes.Count());
        }

        private HtmlNode GetTrNode()
        {
            return new HtmlNode(HtmlNodeType.Element, new HtmlDocument(), 0)
            {
                Name = "tr"
            };
        }

        [TestMethod]
        public void GetTrNodes_NoExists_Return0()
        {
            int expected = 0;
            string tableXpath = "//table";
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(Reader.ReadHtml(@"HtmlData\template.html"));

            IEnumerable<HtmlNode> nodes = htmlTableService.GetTrNodes(document, tableXpath);

            Assert.AreEqual(expected, nodes.Count());
        }

        [TestMethod]
        public void GetThNodes_Exists_ReturnData()
        {
            var trNode = GetTrNode();
            trNode.AppendChild(new HtmlNode(HtmlNodeType.Element, new HtmlDocument(), 0)
            {
                Name = "th"
            });

            var node = htmlTableService.GetThNode(trNode);  

            Assert.IsNotNull(node);          
        }

        [TestMethod]
        public void GetThNodes_NotExists_ReturnNull()
        {
            var trNode = GetTrNode();

            var node = htmlTableService.GetThNode(trNode);  

            Assert.IsNull(node);          
        }

        [TestMethod]
        public void GetTdNode_Exists_ReturnData()
        {
            var trNode = GetTrNode();
            trNode.AppendChild(new HtmlNode(HtmlNodeType.Element, new HtmlDocument(), 0)
            {
                Name = "td"
            });

            var node = htmlTableService.GetTdNode(trNode);  

            Assert.IsNotNull(node);    
        }

        
        [TestMethod]
        public void GetTdNode_Exists_ReturnNull()
        {
            var trNode = GetTrNode();

            var node = htmlTableService.GetTdNode(trNode);  

            Assert.IsNull(node);    
        }
    }
}