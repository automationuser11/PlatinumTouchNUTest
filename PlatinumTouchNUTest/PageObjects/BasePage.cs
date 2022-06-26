using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework; 

namespace PlatinumTouchNUTest.PageObjects
{
    class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public void FillText(IWebElement el, string text)
        {
            el.Clear();
            el.SendKeys(text);
        }
        public void Click(IWebElement el)
        {
            Thread.Sleep(1000);
            el.Click();
        }
        public string GetText(IWebElement el)
        {
            return el.Text;
        }

    }
}
