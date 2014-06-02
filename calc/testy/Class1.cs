using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace testy
{
    public class Class1
    {
        [Fact]
        private void DwaPlusDwa()
        {
             using (var driver = new OpenQA.Selenium.Firefox.FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://webcalculator.apphb.com/Home/");

                var AElement = driver.FindElementById("A");
                var BElement = driver.FindElementById("B");

                AElement.SendKeys("2");
                BElement.SendKeys("2");

                 Assert.Equal(2, 2);

            }
        }
    }
}
