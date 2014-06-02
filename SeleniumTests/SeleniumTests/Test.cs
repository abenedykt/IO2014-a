using Xunit;

namespace SeleniumTests
{
    public class Test
    {
        private DriverToTest driver;
        public Test()
        {
            driver = new DriverToTest();
        }
        [Fact]
        private void CzyDodaje()
        {
            var x = driver.Go("32","23");
            Assert.Equal(x,"55");
        }
        [Fact]
        private void CzyMnozy()
        {
            var x = driver.Go("32", "2");
            Assert.Equal(x,"64");
        }
    }

}



//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Remote;

//namespace SeleniumTests
//{
//    public class TestingBotDriver : RemoteWebDriver
//    {
//        public TestingBotDriver(ICommandExecutor commandExecutor, ICapabilities desiredCapabilities)
//            : base(commandExecutor, desiredCapabilities)
//        {
//        }

//        public TestingBotDriver(ICapabilities desiredCapabilities)
//            : base(new Uri("http://hub.testingbot.com:4444/wd/hub"), desiredCapabilities)
//        {
//        }

//        public TestingBotDriver(Uri remoteAddress, ICapabilities desiredCapabilities)
//            : base(remoteAddress, desiredCapabilities, TimeSpan.FromSeconds(400))
//        {
//        }

//        public String GetSessionId()
//        {
//            return this.SessionId.ToString();
//        }

//        public void UpdateTestStatus(String sessionId, bool success, String testName)
//        {
//            var url = "http://webcalculator.apphb.com/Home/Add" + sessionId;
//            var request = (HttpWebRequest)HttpWebRequest.Create(url);
//            request.ContentType = "application/x-www-form-urlencoded";
//            request.Method = "POST";
//            const string username = "api_key";
//            const string password = "api_secret";

//            const string usernamePassword = username + ":" + password;
//            var mycache = new CredentialCache { { new Uri(url), "Basic", new NetworkCredential(username, password) } };
//            request.Credentials = mycache;
//            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(usernamePassword)));

//            using (var writer = new StreamWriter(request.GetRequestStream()))
//            {
//                writer.Write("test[success]=" + (success ? "1" : "0") + "&test[name]=" + testName);
//            }

//            var response = request.GetResponse();
//            response.Close();
//        }
//    }


//    public class Test
//    {
//        private TestingBotDriver driver;

//    }
//}
