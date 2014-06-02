using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium;


namespace SeleniumWebBrowser.Tests
{
    public class PageObjectsTests
    {
        private readonly ISelenium _selenium;

        public PageObjectsTests(ISelenium selenium)
        {
            this._selenium = selenium;
            if (!selenium.GetTitle().Contains("home"))
            {
                selenium.Open("/");
            }
        }

        public WebCalculatorSite ClickSelenium()
        {
            _selenium.Click("link=selenium");
            _selenium.WaitForPageToLoad("30000");
            return new WebCalculatorSite(_selenium);
        }


        public WebCalculatorSite ClickBlogYear(string year)
        {
            _selenium.Click("link=" + year);
            _selenium.WaitForPageToLoad("30000");
            return new WebCalculatorSite(_selenium);
        }

    }
}
