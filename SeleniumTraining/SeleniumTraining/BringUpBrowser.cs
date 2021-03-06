﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SeleniumTraining
{
    public class BringUpBrowser
    {
        public IWebDriver Driver { get; }

        public BringUpBrowser()
        {

        }
        public BringUpBrowser(string type, string uri)
        {
            if (type.ToLower().Equals("chrome"))
            {
                this.Driver = new ChromeDriver();
                this.Driver.Url = uri;
                this.Driver.Manage().Window.Maximize();
            }
            else if (type.ToLower().Equals("firefox"))
            {
                this.Driver = new FirefoxDriver();
                this.Driver.Url = uri;
                this.Driver.Manage().Window.Maximize();
            }
            else
            {
                throw new Exception("Did not match \"firefox\" or \"chrome\" ");
            }

        }
        internal void Wait()
        {

        }

    }
}
