using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PlatinumTouchNUTest.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PlatinumTouchNUTest.Tests
{
    class SystemRelayInstallTest
    {
        static void Main(string[] arg)
        {
            
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://localhost:8080/ ";
            AnalogOutput AO = new AnalogOutput(driver);
            RelayLayout rl = new RelayLayout(driver);
            DashBoardPage db = new DashBoardPage(driver);
            db.MainMenu();
            db.GoToSystem();
            db.GoToRelayLayout();
            db.GoToSlot1();

            rl.FillInfo1();
            db.GoToSlot2();
            rl.FillInfo2();
            db.ClickSaveChanges();
            db.MainMenu();
            db.GoToAnalogOutput();
            db.SlotAnalogOut();
            AO.FillInfoAO();
            db.ClickSaveChanges();

        }
    }
}
