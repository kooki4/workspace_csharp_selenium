using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SeleniumTraining
{
    class BringUpBrowser
    {
        public IWebDriver Driver { get; }

        public BringUpBrowser(string type, string uri)
        { 
            if (type.Equals("chrome"))
            {
                this.Driver = new ChromeDriver();
                this.Driver.Url = uri;
            }
            else if (type.Equals("firefox"))
            {
                this.Driver = new FirefoxDriver();
                this.Driver.Url = uri;
            }
        }

    }
}
