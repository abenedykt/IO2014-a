using System;
using System.Drawing.Imaging;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var driver = new ChromeDriver())
                {
                    driver.Navigate().GoToUrl("http://webcalculator.apphb.com/");

                    var liczbaA = driver.FindElementById("A");
                    var liczbaB = driver.FindElementById("B");

                    //var obliczButton = driver.FindElementByXPath("//html//input=*[@value['dodaj']]");
                    var obliczButton = driver.FindElementByXPath("//input=@value['dodaj']");

                    liczbaA.SendKeys("2");
                    liczbaB.SendKeys("4");

                    obliczButton.Click();

                    driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        
    }
}
