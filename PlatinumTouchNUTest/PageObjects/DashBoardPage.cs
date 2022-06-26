using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlatinumTouchNUTest.PageObjects
{
    class DashBoardPage:BasePage
    {
        public  DashBoardPage(IWebDriver driver):base(driver)
        {
        }
        public IWebElement MainMenuBtn => Driver.FindElement(By.CssSelector(".nav-icon.icon-lines"));       
        public IWebElement SystemBtn => Driver.FindElement(By.CssSelector(".icon-wrench"));
        public IWebElement RelayLayoutBtn => Driver.FindElement(By.CssSelector("[data-key='System|Relay Layout']"));

        public IWebElement Slot1Btn => Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(1) > td > p"));
        public IWebElement Slot2Btn => Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(12) > td > p"));
        public IWebElement SaveChanges => Driver.FindElement(By.CssSelector("#saveAndCancelPlaceholder > div > button:nth-child(1)"));
        public IWebElement AnalogOutput => Driver.FindElement(By.CssSelector("#nav-floater > div:nth-child(6) > ul:nth-child(2) > li:nth-child(2)"));
        public IWebElement Slot1AnalogBtn => Driver.FindElement(By.CssSelector("#grid0 > div.k-grid-content.k-auto-scrollable > table > tbody > tr.k-grouping-row > td"));

        public void MainMenu()
        {
            Click(MainMenuBtn);
        }
        public void GoToSystem()
        {
            Click(SystemBtn);
        }
        public void GoToRelayLayout()
        {
            Click(RelayLayoutBtn);
        }
        public void GoToSlot1()
        {
            Thread.Sleep(1000);
            Click(Slot1Btn);
            
          
        }
        public void GoToSlot2()
        {
            Thread.Sleep(1000);
            Click(Slot2Btn);
        }
        public void ClickSaveChanges()
        {
            Thread.Sleep(1000);
            Click(SaveChanges);
        }
        public void GoToAnalogOutput()
        {
            Thread.Sleep(1000);
            Click(AnalogOutput);
        }
        public void SlotAnalogOut()
        {
            Thread.Sleep(1000);
            Click(Slot1AnalogBtn);
        }


    }
}
