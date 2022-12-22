using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    class PrintersPageObject
    {
        private IWebDriver driver;
        private Actions action;

        private readonly By HomePrinters = By.XPath("//a[@class='pl-btn pl-btn--blue pl-btn--small']");

        public PrintersPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public HomePrintersPageObject HomePrintersClick()
        {
            action.MoveToElement(driver.FindElement(HomePrinters)).Click();
            action.Perform();
            return new HomePrintersPageObject(driver);
        }
    }
}
