using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTraining
{
    class Demo
    {
        static void Main(string[] args)
        {
            BringUpBrowser browser = new BringUpBrowser("chrome", "http://testing.todvachev.com/special-elements/drop-down-menu-test/");
            IWebElement dropDown = browser.Driver.FindElement(By.XPath("//select[@name='DropDownTest']"));
            OpenQA.Selenium.Support.UI.SelectElement options = new SelectElement(dropDown);
            options.SelectByText("Saab");
            Console.WriteLine(options.IsMultiple);
            OpenQA.Selenium.Support.UI.WebDriverWait bla = new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(30));
            bla.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("")));
            
            
            /*
            // CHECK BOX
            BringUpBrowser browser = new BringUpBrowser("chrome", "http://testing.todvachev.com/special-elements/check-button-test-3/");

            List<IWebElement> checkboxes = browser.Driver.FindElements(By.Name("vehicle")).ToList();
            foreach (IWebElement checkbox in checkboxes)
            {
                // make this as a NUnit test to stop using the Main methon probably :) 
                if (checkbox.Selected)
                {
                    Console.WriteLine("Checkox with value \"" + checkbox.GetAttribute("value") + "\" is CHECKED");
                }
                else
                {
                    Console.WriteLine("Checkox with value \"" + checkbox.GetAttribute("value") + "\" is NOT CHECKED");
                }
            }
            */
            Console.ReadLine();
            browser.Driver.Quit();
        }
    }
}
