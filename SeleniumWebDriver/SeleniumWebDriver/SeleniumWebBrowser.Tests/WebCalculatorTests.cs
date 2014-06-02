using NUnit.Framework;
using Selenium;
using Selenium.Webdriver.Domify;


namespace SeleniumWebBrowser.Tests
{
    [TestFixture]
    public class WebCalculatorTests
    {
        private ISelenium _selenium;
        [SetUp]
        public void Setup()
        {
            _selenium = new DefaultSelenium("localhost", 4444, "*chrome", "http://webcalculator.apphb.com/");
            _selenium.Start();
        }

        [TearDown]
        public void Teardown()
        {
            _selenium.Stop();
        }

        [Test]
        public void ShouldLoadHomeThenGoToXpathTutorial()
        {
            //PageObjectsTests home = new PageObjectsTests(_selenium);
            //WebCalculatorSite seleniumTutorials = home.ClickSelenium();
            //WebCalculatorSite seleniumXPathTutorial = seleniumTutorials.ClickXpathTutorial();
            //Assert.True(seleniumXPathTutorial.
            //            IsInputOnScreen(SeleniumXPathTutorial.FirstInput));
            //Assert.True(seleniumXPathTutorial
            //            .IsInputOnScreen(SeleniumXPathTutorial.SecondInput));
            //Assert.True(seleniumXPathTutorial
            //            .IsInputOnScreen(SeleniumXPathTutorial.Total));
        }

    }
}
