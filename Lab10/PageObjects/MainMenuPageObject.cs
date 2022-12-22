using Lab10.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.PageObjects
{
    class MainMenuPageObject
    {
        private const string BASE_URL = "https://www.canon.ru/";

        private IWebDriver driver;
        private Actions action;

        private readonly By YesCookieButton = By.Id("_evidon-accept-button");
        private readonly By ForProfessionalPhotoAndVideoMenu = By.XPath("//span[text()='Для профессионалов фото и видео']");
        private readonly By ProductElementMenu = By.XPath("//a[@class='nav__menu-link canon-color--grey-darkest canon-paragraph--medium']");
        private readonly By PrintersElementMenu = By.LinkText("Принтеры");
        private readonly By CamerasElementMenu = By.LinkText("Камеры");
        private readonly By LensesElementMenu = By.LinkText("Объективы");
        private readonly By LensesForDigitalSLRcamerasElement = By.LinkText("Объективы для цифровых зеркальных камер EOS");
        private readonly By FlashSpeedlite = By.XPath("//a[@href='https://www.canon.ru/cameras/speedlite-flashes/']");
        private readonly By SupportElementMenu = By.XPath("//*[@id='main-header']/nav/div[3]/div/ul/li[5]/a");
        private readonly By MirrorlessCamerasElement = By.LinkText("Беззеркальные камеры");
        private readonly By NewsletterSubscriptionElement = By.XPath("//a[@class='nav__submenu-inner-link canon-link canon-link-- canon-link--fwd canon-link--small canon-lightbox-link']");
        private readonly By SearchElement = By.XPath("//button[@class='nav__search-btn nav__search-btn--desktop canon-color--grey-darkest canon-paragraph--title-small']");
        private readonly By SearchElementField = By.Id("nav__search-form-input");
        private readonly By UserAccountElement = By.XPath("//button[@class='nav__my-canon-link canon-color--grey-darkest canon-paragraph--medium']");
        private readonly By BasketElement = By.Id("CartIcon");

        //Элементы для заполнения для рассылки
        private readonly By FirstNameInputField = By.Id("firstname");
        private readonly By LastNameInputField = By.Id("lastname");
        private readonly By EmailInputField = By.Id("email");
        private readonly By SubmitElement = By.XPath("//input[@type='submit']");

        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);            
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);            
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
            ClickYesCookie();
        }

        public ForProfessionalPhotoAndVideoPAgeObject ClickForProfessionalPhotoAndVideoPAgeObjectElement()
        {
            driver.FindElement(ForProfessionalPhotoAndVideoMenu).Click();
            return new ForProfessionalPhotoAndVideoPAgeObject(driver);
        }

        public MainMenuPageObject HoverProductElement()
        {
            action.MoveToElement(driver.FindElement(ProductElementMenu));
            action.Perform();
            return this;
        }

        public MainMenuPageObject ClickYesCookie()
        {
            driver.FindElement(YesCookieButton).Click();
            return this;
        }

        public MainMenuPageObject HoverPrintersElement()
        {
            action.MoveToElement(driver.FindElement(PrintersElementMenu));
            action.Perform();
            return this;
        }

        public MainMenuPageObject HoverCamerasElement()
        {
            action.MoveToElement(driver.FindElement(CamerasElementMenu));
            action.Perform();
            return this;
        }

        public MirrorlessCamerasPageObject ClickMirrorlessCamerasElement()
        {
            action.MoveToElement(driver.FindElement(MirrorlessCamerasElement)).Click();
            action.Perform();
            return new MirrorlessCamerasPageObject(driver);
        }

        public PrintersPageObject ClickPrintersElement()
        {
            action.MoveToElement(driver.FindElement(PrintersElementMenu)).Click();
            action.Perform();
            return new PrintersPageObject(driver);
        }

        public SupportPageObject ClickSupportElement()
        {
            action.MoveToElement(driver.FindElement(SupportElementMenu)).Click();
            action.Perform();
            return new SupportPageObject(driver);
        }

        public MainMenuPageObject ClickSearchText()
        {
            action.MoveToElement(driver.FindElement(SearchElement)).Click();
            action.Perform();
            return this;
        }
        public MainMenuPageObject ClickSearchTextField(string SearchText)
        {
            driver.FindElement(SearchElementField).SendKeys(SearchText);
            driver.FindElement(SearchElementField).SendKeys(Keys.Enter);
            return this;
        }

        public MainMenuPageObject ClickUserAccountIcon()
        {
            driver.FindElement(UserAccountElement).Click();
            return this;
        }

        public MainMenuPageObject NewsletterSubscriptionClick()
        {
            driver.FindElement(NewsletterSubscriptionElement).Click();
            return this;
        }

        public MainMenuPageObject SignUpToReceiveCanonNewsAndOffers(string firsname, string lastname, string email)
        {
            IWebElement iframe = driver.FindElement(By.CssSelector(".lightbox__content canon-bg--white>iframe"));
            driver.SwitchTo().Frame(iframe);
            driver.FindElement(FirstNameInputField).SendKeys(firsname);
            driver.FindElement(LastNameInputField).SendKeys(lastname);
            driver.FindElement(EmailInputField).SendKeys(email);
            driver.FindElement(SubmitElement).Click();
            return this;
        }

        public MainMenuPageObject HoverLensesElement()
        {
            action.MoveToElement(driver.FindElement(LensesElementMenu));
            action.Perform();
            return this;
        }

        public CameraLensesPageObject ClickLensesForDigitalSLRcameras()
        {
            driver.FindElement(LensesForDigitalSLRcamerasElement).Click();
            return new CameraLensesPageObject(driver);
        }

        public void ClickBasket()
        {
            driver.FindElement(BasketElement);
        }

        public SpeedliteFlashesPageObject ClickSpeedliteFlashesPage()
        {
            action.MoveToElement(driver.FindElement(FlashSpeedlite)).Click();
            action.Perform();
            return new SpeedliteFlashesPageObject(driver);
        }
    }
}
