using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace PlatinumTouchNUTest.PageObjects
{
    class RelayLayout :BasePage
    {
        public RelayLayout(IWebDriver driver) : base(driver)
        {
        }
        
        public void FillInfo1()
        {
     /*1*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(2) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(2)")).Click();
            Thread.Sleep(1000);

     /*2*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(3) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(3) > td:nth-child(3) > select > option:nth-child(7)")).Click();
            Thread.Sleep(1000);                 

     /*3*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(4) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(6)")).Click();
            Thread.Sleep(1000);

     /*4*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(5) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(21)")).Click();
            Thread.Sleep(1000);
     
     /*5*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(6) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(22)")).Click();
            Thread.Sleep(1000);
     
     /*6*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(7) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(23)")).Click();
            Thread.Sleep(1000);
     
     /*7*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(8) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(8)")).Click();
            Thread.Sleep(1000);
     
     /*8*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(9) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(12)")).Click();
            Thread.Sleep(1000);
     
     /*9*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(10) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(11)")).Click();
            Thread.Sleep(1000);
     
    /*10*/  Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(11) > td:nth-child(3)")).Click();
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(9)")).Click();
            Thread.Sleep(1000);

            /*Exit*/
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(1) > td > p")).Click();


        }
        public void FillInfo2()
        {
    /*11*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(13) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(25)")).Click();
             Thread.Sleep(1000);

    /*12*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(14) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(17)")).Click();
             Thread.Sleep(1000);

    /*13*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(15) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(20)")).Click();
             Thread.Sleep(1000);

    /*14*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(16) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(18)")).Click();
             Thread.Sleep(1000);

    /*15*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(17) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(36)")).Click();
             Thread.Sleep(1000);
      
    /*16*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(18) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(40)")).Click();
             Thread.Sleep(1000);
      
    /*17*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(19) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(33)")).Click();
             Thread.Sleep(1000);
      
    /*18*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(20) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(4)")).Click();
             Thread.Sleep(1000);
      
    /*19*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(21) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.active > td:nth-child(3) > select > option:nth-child(38)")).Click();
             Thread.Sleep(1000);
      
    /*20*/   Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(22) > td:nth-child(3)")).Click();
             Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-alt.active > td:nth-child(3) > select > option:nth-child(37)")).Click();
             Thread.Sleep(1000);

            /*Exit*/
            Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(12) > td")).Click();


        }


    }
}
