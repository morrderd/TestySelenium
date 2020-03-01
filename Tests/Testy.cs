using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using Implementation;
using Implementation.Pages;

namespace Tests
{
    [TestFixture]
    public class Testy
    {
        [SetUp]
        public void SetUp()
        {
            Browser browser = new Browser();
            browser.openBrowser();
        }

        [Test]
        public void SearchTextFromAboutPage()
        {
            HomePage homePage = new HomePage();
            homePage.goToPage();
            
        }
         
        [TearDown]
        public void TearDown()
        {
            
        }
    }
}
