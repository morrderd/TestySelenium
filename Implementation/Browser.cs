using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class Browser
    {
        private IWebDriver driver = new ChromeDriver();

        public Browser()
        {
        }

        protected void OpenBrowser(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBroser()
        {
            driver.Quit();
        }
        
    }
}
