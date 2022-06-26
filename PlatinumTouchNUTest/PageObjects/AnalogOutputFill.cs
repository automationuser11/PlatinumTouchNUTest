using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlatinumTouchNUTest.PageObjects
{
    class AnalogOutput:BasePage
    {
        public AnalogOutput(IWebDriver driver) : base(driver)
        {
        }
        public void FillInfoAO()
        {
     /*1*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(2) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(4)")).Click();
            Thread.Sleep(1000);

     /*2*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(3) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(2)")).Click();
            Thread.Sleep(1000);

     /*3*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(4) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(8)")).Click();
            Thread.Sleep(1000);

     /*4*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(5) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(6)")).Click();
            Thread.Sleep(1000);

     /*5*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(6) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(4)")).Click();
            Thread.Sleep(1000);

     /*6*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(7) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(10)")).Click();
            Thread.Sleep(1000);

     /*7*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(8) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(5)")).Click();
            Thread.Sleep(1000);

     /*8*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(9) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(7)")).Click();
            Thread.Sleep(1000);

     /*9*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(10) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(9)")).Click();
            Thread.Sleep(1000);

           
     /*10*/ Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(11) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(4)")).Click();
            Thread.Sleep(1000);


        }
    }
}
