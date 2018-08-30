using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumTraining;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    [TestFixture]
    class NUnitTestsInitialSetup
    {
        BringUpBrowser browser;
        WebDriverWait bla;  


        [SetUp]
        public void Initialize(){
            browser = new BringUpBrowser("Chrome","https://dir.bg");
            bla = new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(30));
        }

        [Test]
        public void GetTitleOfHomepage()
        {
            Assert.AreEqual("Dir.bg - Българският Интернет портал!", browser.Driver.Title);
            bla.Until(ExpectedConditions.ElementIsVisible(By.Id("g")));
        }

       [TearDown]
       public void CloseDriver()
       {
           browser.Driver.Quit();
       }

    }
}
