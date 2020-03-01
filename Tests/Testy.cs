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
        HomePage homePage = new HomePage();

        [SetUp]
        public void SetUp()
        {
            homePage.GoToHomePage();
        }

        [Test]
        public void SearchTextFromAboutPage()
        {
            
        }
         
        [TearDown]
        public void TearDown()
        {
            homePage.CloseBroser();
        }
    }
}
