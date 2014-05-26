using ClassLibrary1;
using Xunit;

namespace ClassLibrary2
{
    public class Class1
    {

        [Fact]
        public void WypiszFissDlaTrzy()
        {
            var game = new FissBass();
            var p1 = game.Play(3);
            Assert.Equal("Fiss", p1);
        }
        [Fact]
        public void WypiszJedenDlaJeden()
        {
            var game = new FissBass();
            var p1 = game.Play(1);
            Assert.Equal(1, p1);
        }
        [Fact]
        public void WypiszBassDlaPiec()
        {
            var game = new FissBass();
            var p1 = game.Play(5);
            Assert.Equal("Bass", p1);
        }
        [Fact]
        public void WypiszFissBassDla15()
        {
            var game = new FissBass();
            var p1 = game.Play(15);
            Assert.Equal("Fiss Bass", p1);
        }
          

      
    }
}
