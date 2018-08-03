using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace IdolCheckApartPrice
{
    class Demo
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://idol.bg/?page_id=3&building_id=24&floor_id=171&floor_type_id=3&apartment_id=675&apartment_type_id=3";
            System.Threading.Thread.Sleep(2000);
            IWebElement sqrPrice = driver.FindElement(By.XPath("//em[contains(text(),'1 063')]"));
            Console.WriteLine(sqrPrice.Text);
            Assert.AreEqual("(1 063 евро/кв.м)", sqrPrice.Text);
            Console.ReadLine();
            driver.Close();
        }
    }
}
