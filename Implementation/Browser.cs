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
        private IWebDriver driver;
        public Browser()
        {
            
        }

        public void openBrowser()
        {
            driver = new ChromeDriver();
        }
    }
}
