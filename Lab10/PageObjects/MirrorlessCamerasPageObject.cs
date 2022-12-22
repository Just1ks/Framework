using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    public class MirrorlessCamerasPageObject
    {
        private const string BASE_URL = "https://www.canon.ru/cameras/mirrorless-cameras/";

        private readonly By SearchFilterButton = By.XPath("//button[@class='pl-more-button collapsed product-filter-toggle']");
        private readonly By FullFrameCheckbox= By.XPath("//label[text()='ПОЛНОКАДРОВЫЙ']");
        private readonly By SearchResultButton = By.XPath("//input[@name='apply']");

        private IWebDriver driver;
        private Actions action;

        public MirrorlessCamerasPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));            
        }

        public MirrorlessCamerasPageObject SearchFilterClick()
        {            
            action.MoveToElement(driver.FindElement(SearchFilterButton)).Click();
            action.Perform();
            return this;
        }

        public MirrorlessCamerasPageObject FullFrameCheckboxClick()
        {
            action.ScrollToElement(driver.FindElement(FullFrameCheckbox));
            action.Perform();
            driver.FindElement(FullFrameCheckbox).Click();
            return this;
        }

        public MirrorlessCamerasPageObject SearchRelustClick()
        {
            action.ScrollToElement(driver.FindElement(SearchResultButton));
            action.Perform();
            driver.FindElement(SearchResultButton).Click();            
            return this;
        }
    }
}
