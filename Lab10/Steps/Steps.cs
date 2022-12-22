using Lab10.Driver;
using Lab10.PageObjects;
using Lab10.Service;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Steps
{
    public class Steps
    {
        public IWebDriver driver;

        public void InitBrowser()
        {
            driver = DriverSingleton.OpenBrowser();
        }

        public void CloseBrowser()
        {
            Driver.DriverSingleton.CloseBrowser();
        }

        public void SearchCamera()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(driver);
            mainPage.OpenPage();
            mainPage.ClickSearchText();
            mainPage.ClickSearchTextField(CameraCreator.WithCredentials().GetModel());           
        }

        public void OpenPrinterPage()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.HoverProductElement();            
            mainMenu.ClickPrintersElement();
        }

        public void OpenHomePrintersPage()
        {
            PrintersPageObject printersPage = new PrintersPageObject(driver);
            printersPage.HomePrintersClick();
        }

        public void SearchFilterColorPrinterWithWIFI()
        {
            HomePrintersPageObject homePrintersPage = new HomePrintersPageObject(driver);
            homePrintersPage.SearchFilterClick();
            homePrintersPage.ColorCheckboxClick();
            homePrintersPage.WIFICheckboxClick();
            homePrintersPage.SearchRelustClick();
        }

        public void OpenMirrirlessCamerasPage()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.HoverProductElement();
            mainMenu.HoverCamerasElement();
            mainMenu.ClickMirrorlessCamerasElement();
        }

        public void SearchFilterMirrorlessFullFrameCameras()
        {
            MirrorlessCamerasPageObject mirrorlessPage = new MirrorlessCamerasPageObject(driver);
            mirrorlessPage.SearchFilterClick();
            mirrorlessPage.FullFrameCheckboxClick();
            mirrorlessPage.SearchRelustClick();
        }

        public void NewsletterSubscription()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.ClickUserAccountIcon();
            mainMenu.NewsletterSubscriptionClick();
            mainMenu.SignUpToReceiveCanonNewsAndOffers(UserCreator.UserNameTestData, UserCreator.UserSurnameTestData, UserCreator.UserEmailTestData);
        }

        public void OpenSupportPage()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.ClickSupportElement();
        }

        public void DownloadSoftForCamera()
        {
            SupportPageObject supportPage = new SupportPageObject(driver);
            supportPage.ClickSearchCamera(CameraCreator.WithCredentials().GetModel());
            supportPage.ClickSoftForCamera();
            supportPage.SetParametersForDownload();
            supportPage.DownloadSoftForCamera();
            supportPage.LicenseClick();
        }

        public void OpenLensesForDigitalSLRcameras()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.HoverProductElement();
            mainMenu.HoverLensesElement();
            mainMenu.ClickLensesForDigitalSLRcameras();
        }

        public void SearchLensForLandscapeWithStabilizer()
        {
            CameraLensesPageObject cameraLensesPage = new CameraLensesPageObject(driver);
            cameraLensesPage.SearchFilterClick();
            cameraLensesPage.StabilizerCheckboxClick();
            cameraLensesPage.LandscapesCheckboxClick();
            cameraLensesPage.SearchRelustClick();
        }

        public void OpenForProfessionalPhotoAndVideoPage()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.ClickForProfessionalPhotoAndVideoPAgeObjectElement();
        }

        public void SearchProectorsInForProfessionalPhotoAndVideo()
        {
            ForProfessionalPhotoAndVideoPAgeObject forProfessionalPhotoAndVideoPage = new ForProfessionalPhotoAndVideoPAgeObject(driver);
            forProfessionalPhotoAndVideoPage.ClickProectorsElement();
        }

        public void OpenBasket()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.ClickBasket();
        }

        public void OpenSpeedliteFlashesPage()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.HoverProductElement();
            mainMenu.HoverCamerasElement();
            mainMenu.ClickSpeedliteFlashesPage();
        }

        public void OpenSpeedliteFlash()
        {
            SpeedliteFlashesPageObject speedliteFlashesPage = new SpeedliteFlashesPageObject(driver);
            speedliteFlashesPage.ClickFlash(SpeedliteFlashCreator.WithCredentials().GetModel());
        }

        public void OpenWriteFirstFeedback()
        {
            SpeedliteFlashesPageObject speedliteFlashesPage = new SpeedliteFlashesPageObject(driver);
            speedliteFlashesPage.ClickFirstFeedbackButton();
        }

        public void WriteFirstFeedback()
        {
            SpeedliteFlashesPageObject speedliteFlashesPage = new SpeedliteFlashesPageObject(driver);
            speedliteFlashesPage.ClickFourStars();
            speedliteFlashesPage.SendUserName();
            speedliteFlashesPage.SendUserEmail();
            speedliteFlashesPage.ClickAccept();
            speedliteFlashesPage.ClickPublish();
        }
    }
}
