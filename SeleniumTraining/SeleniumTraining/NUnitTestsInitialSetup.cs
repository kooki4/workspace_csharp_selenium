using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumTraining;
using OpenQA.Selenium;

namespace ConsoleApplication1
{
    class NUnitTestsInitialSetup
    {
        BringUpBrowser browser;

        [SetUp]
        public void Initialize(){
            browser = new BringUpBrowser("Chrome","https://dir.bg");
            }

        [Test]
        public void GetTitleOfHomepage()
        {
            Assert.AreEqual("Dir.bg - Българският Интернет портал!", browser.Driver.Title);
        }

       [TearDown]
       public void CloseDriver()
       {
           browser.Driver.Quit();
       }

    }
}
