using Lab10.Driver;
using Lab10.PageObjects;
using Lab10.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Lab10
{
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(5000);
            steps.CloseBrowser();
        }

        [Test] //1. Просмотр "корзины"
        public void ViewBasketTest()
        {
            steps.OpenBasket();
        }

        [Test] //2. Поиск модели фотоаппарата canon
        public void SearchCameraModelTest() 
        {
            steps.SearchCamera();
        }

        [Test] //3. Поиск цветного принтера для дома с Wi-Fi
        public void SearchColorHomePrinterWithWIFITest()
        {
            steps.OpenPrinterPage();
            steps.OpenHomePrintersPage();
            steps.SearchFilterColorPrinterWithWIFI();
        }

        [Test] //5. Поиск беззеркальной полнокадровой камеры
        public void SearchMirrorlessFullFrameCameraTest()
        {
            steps.OpenMirrirlessCamerasPage();
            steps.SearchFilterMirrorlessFullFrameCameras();
        }

        [Test] //6. Подписка на рассылку
        public void NewsletterSubscriptionTest()
        {
            steps.NewsletterSubscription();
        }

        [Test] //7. Просмотр необходимого ПО для фотокамеры
        public void SearchCameraSoftTest()
        {
            steps.OpenSupportPage();
            steps.DownloadSoftForCamera();
        }

        [Test] //8. Отправка первого отзыва (4 звезды)
        public void SendFeedbackTest()
        {
            steps.OpenSpeedliteFlashesPage();
            steps.OpenSpeedliteFlash();
            steps.OpenWriteFirstFeedback();
            steps.WriteFirstFeedback();
        }

        [Test] //9. Поиск объектива к зеркальной камере для съёмки пейзажей со стабилизатором
        public void SearchLensForLandscapeWithStabilizerTest()
        {
            steps.OpenLensesForDigitalSLRcameras();
            steps.SearchLensForLandscapeWithStabilizer();
        }

        [Test] //10. Поиск проектора
        public void SearchProectorsTest()
        {
            steps.OpenForProfessionalPhotoAndVideoPage();
            steps.SearchProectorsInForProfessionalPhotoAndVideo();            
        }

        
    }    
}