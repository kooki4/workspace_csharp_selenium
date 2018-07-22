using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    class Demo
    {
        static void Main(string[] args)
        {
            BringUpBrowser browser = new BringUpBrowser("chrome", "http://testing.todvachev.com/");
            IWebElement photos = browser.Driver.FindElement(By.XPath("//img[@class='alignnone wp-image-37 size-full']"));
            Console.WriteLine(photos.GetAttribute("src"));
            BringUpBrowser browser2 = new BringUpBrowser("chrome", photos.GetAttribute("src").ToString());
            Console.ReadLine();
        }
    }
}
