using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10.PageObjects
{
    public class CameraLensesPageObject
    {
        private const string BASE_URL = "https://www.canon.ru/lenses/";

        private IWebDriver driver;
        private Actions action;

        private readonly By SearchFilterButton = By.XPath("//button[@class='pl-more-button collapsed product-filter-toggle']");
        private readonly By StabilizerCheckbox = By.XPath("//label[text()='Стабилизатор']");
        private readonly By LandscapesCheckbox = By.XPath("//label[text()='Пейзажи']");
        private readonly By SearchResultButton = By.XPath("//input[@name='apply']");

        public CameraLensesPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
        }

        public CameraLensesPageObject SearchFilterClick()
        {
            action.MoveToElement(driver.FindElement(SearchFilterButton)).Click();
            action.Perform();
            return this;
        }

        public CameraLensesPageObject StabilizerCheckboxClick()
        {
            Thread.Sleep(2000);
            driver.FindElement(StabilizerCheckbox).Click();
            return this;
        }
        public CameraLensesPageObject LandscapesCheckboxClick()
        {
            Thread.Sleep(2000);
            driver.FindElement(LandscapesCheckbox).Click();
            return this;
        }

        public CameraLensesPageObject SearchRelustClick()
        {
            driver.FindElement(SearchResultButton).Click();
            return this;
        }
    }
}
