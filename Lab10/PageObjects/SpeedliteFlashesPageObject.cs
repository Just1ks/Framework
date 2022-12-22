using Lab10.Model;
using Lab10.Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    public class SpeedliteFlashesPageObject
    {
        private const string BASE_URL = "https://www.canon.ru/cameras/speedlite-flashes/";

        private IWebDriver driver;
        private Actions action;

        private By FlashElement;
        private readonly By WriteFeedBackFirstElement = By.XPath("//button[@id='first-to-write']");
        private readonly By FourStarsElement = By.Id("bv-radio-rating-4");
        private readonly By InputUserName = By.XPath("//input[@name='usernickname']");
        private readonly By InputUserEmail = By.XPath("//input[@name='hostedauthentication_authenticationemail']");
        private readonly By AcceptCheckBox = By.XPath("//label[@class='bv-fieldset-label-checkbox']");
        private readonly By PublishElement = By.XPath("//button[@aria-label='Опубликовать обзор']");

        public SpeedliteFlashesPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
        }

        public SpeedliteFlashesPageObject ClickFlash(string model)
        {
            FlashElement = By.LinkText(model);
            action.ScrollToElement(driver.FindElement(FlashElement));
            action.Perform();
            driver.FindElement(FlashElement).Click();
            return this;
        }

        public SpeedliteFlashesPageObject ClickFirstFeedbackButton()
        {
            action.MoveToElement(driver.FindElement(WriteFeedBackFirstElement)).Click();
            action.Perform();
            return this;
        }

        public SpeedliteFlashesPageObject ClickFourStars()
        {
            driver.FindElement(FourStarsElement).Click();
            return this;
        }

        public SpeedliteFlashesPageObject SendUserName()
        {
            action.ScrollToElement(driver.FindElement(InputUserName));
            action.Perform();
            driver.FindElement(InputUserName).SendKeys(UserCreator.UserNameTestData);
            return this;
        }

        public SpeedliteFlashesPageObject SendUserEmail()
        {
            action.ScrollToElement(driver.FindElement(InputUserEmail));
            action.Perform();
            driver.FindElement(InputUserEmail).SendKeys(UserCreator.UserEmailTestData);
            return this;
        }

        public SpeedliteFlashesPageObject ClickAccept()
        {
            action.ScrollToElement(driver.FindElement(AcceptCheckBox));
            action.Perform();
            driver.FindElement(AcceptCheckBox).Click();
            return this;
        }

        public SpeedliteFlashesPageObject ClickPublish()
        {
            action.ScrollToElement(driver.FindElement(PublishElement));
            action.Perform();
            driver.FindElement(PublishElement).Click();
            return this;
        }
    }
}
