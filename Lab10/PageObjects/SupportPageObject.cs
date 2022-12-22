using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    public class SupportPageObject
    {
        private const string BASE_URL = "https://www.canon.ru/support/";

        private readonly By CameraNameInputElement = By.Id("s2id_autogen2");
        private readonly By SoftForCameraElement = By.XPath("//a[@data-tabname='software']");
        private readonly By OperationSystemList = By.Id("download-os");
        private readonly By LanguageList = By.Id("download-language");
        private readonly By DownloadButton = By.XPath("//a[@class='pl-btn pl-btn--blue pl-btn--medium download-btn inline downloaddisclaimer']");

        private IWebDriver driver;
        private Actions action;

        public SupportPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
        }

        public SupportPageObject ClickSearchCamera(string SearchText)
        {
            driver.FindElement(CameraNameInputElement).SendKeys(SearchText);
            driver.FindElement(CameraNameInputElement).SendKeys(Keys.Enter);
            return this;
        }

        public SupportPageObject ClickSoftForCamera()
        {
            driver.FindElement(SoftForCameraElement);
            return this;
        }

        public SupportPageObject SetParametersForDownload()
        {
            driver.FindElement(OperationSystemList).Click();
            driver.FindElement(By.XPath("//option[@value='Windows 10 (64-bit)']")).Click();
            driver.FindElement(LanguageList);
            driver.FindElement(By.XPath("//option[@value='RU']")).Click();            
            return this;
        }

        public SupportPageObject DownloadSoftForCamera()
        {
            action.MoveToElement(driver.FindElement(DownloadButton)).Click();
            action.Perform();
            return this;
        }

        public SupportPageObject LicenseClick()
        {
            driver.FindElement(DownloadButton).Click();
            
            return this;
        }
    }
}
