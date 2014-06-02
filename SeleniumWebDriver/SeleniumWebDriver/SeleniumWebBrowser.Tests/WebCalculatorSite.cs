using System.Windows.Forms;
using OpenQA.Selenium;
using Selenium;

namespace SeleniumWebBrowser.Tests
{
    public class WebCalculatorSite
    {
        private readonly ISelenium _selenium;

        public const string liczbaA = "A";
        public const string liczbaB = "B";
        public const string Sumuj = "dodaj";
       

        public WebCalculatorSite(ISelenium selenium)
        {
            this._selenium = selenium;
        }

        public bool IsInputOnScreen(string locator)
        {
            return _selenium.IsElementPresent(locator);
        }

        public WebCalculatorSite ClickXPath()
        {
            throw new System.NotImplementedException();
        }
    }
}
