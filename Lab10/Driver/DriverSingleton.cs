using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Lab10.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver driver;

        public static IWebDriver OpenBrowser()
        {
            if(driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(190));
                driver.Manage().Window.Maximize();
            }

            return driver;
        }        

        public static void CloseBrowser()
        {
            driver.Quit();            
            driver = null;
        }
    }
}
