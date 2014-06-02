using System;
using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    class DriverToTest
    {
        private readonly FirefoxDriver _firefoxDriver;

        public DriverToTest()
        {
            this._firefoxDriver = new FirefoxDriver();
            _firefoxDriver.Navigate().GoToUrl("http://webcalculator.apphb.com/");
        }

        public string Go( string a, string b)
        {
            var numberA = _firefoxDriver.FindElementById("A");
            var numberB = _firefoxDriver.FindElementById("B");
            var submitButton = _firefoxDriver.FindElementByXPath("//input[@value='dodaj']");

            numberA.SendKeys(a);
            numberB.SendKeys(b);

            submitButton.Click();

            var result = _firefoxDriver.FindElementByTagName("h4").Text;
            return result;
            
        }

    }
}
