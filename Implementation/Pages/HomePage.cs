using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Pages
{
    public class HomePage : Browser
    {
        public HomePage()
        {
            
        }
        public void GoToHomePage()
        {
            OpenBrowser("https://www.google.com/");
        }
    }
}
