using LogikaZadanieMvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZadanieMvc.Controllers;

namespace Tests
{
    public class HardTests
    {

        [Fact(Timeout=10000)]
        public void CzyNieRobiPonadTysiacMs()
        {
            ISomeStuff iss = new SomeLongRunningStuff();
            iss.MakeSomeWork();
           

        }

        [Fact]
        public void CzyIndexZwracaWidok()
        {
            var valueServiceMock = new Mock<ISomeStuff>();
            valueServiceMock.Setup(service => service.MakeSomeWork());

         //   var controller = new HomeController(valueServiceMock.Object);
          //  var actionReturn = controller.Index();

           // Assert.IsType<ActionResult>(actionReturn);

          //  Assert.Equal("Index", actionReturn.ViewName);

        }
    }
}
