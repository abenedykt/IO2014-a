using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using solucja2.App_Start;
using solucja2.Controllers;
using utility;
using Xunit;
using System.Threading;

namespace tests
{
    public class Class1
    {
        [Fact]
        public void SprwdzCzyIndeksWykonujeSie10000()
        {
            var controller = new HomeController(new SomeLongRunningStuff());

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            controller.Index();

            stopWatch.Stop();

            Assert.Equal(10, stopWatch.Elapsed.Seconds);
        }

        [Fact]
        public void SprawdzCzyFunkcjaTrwa10000()
        {
            var some = new SomeLongRunningStuff();

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            some.MakeSomeWork();

            stopWatch.Stop();

            Assert.Equal(10,stopWatch.Elapsed.Seconds);
        }

        [Fact]
        public void SprawdzZwracanyWidokKontrolera()
        {
            var controller = new HomeController(new SomeLongRunningStuff());

            var result = controller.Index() as ViewResult;

            Assert.Equal(string.Empty,result.ViewName);
        }
    }
}
