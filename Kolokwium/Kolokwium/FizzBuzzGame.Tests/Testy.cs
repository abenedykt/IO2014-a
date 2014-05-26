using FizzBuzzGame.Models;
using Xunit;

namespace FizzBuzzGame.Tests
{
    public class Testy
    {
        FizzBuzz game = new FizzBuzz();

        public Testy()
        {
            var game = new FizzBuzz();
        }

        [Fact]
        public void WypisujeFizzDlaTrzy()
        {
            var p1 = game.Play(3);
            Assert.Equal("Fizz", p1);
        }

        [Fact]
        public void WypisujeFizzDlaSzostki()
        {
            var p1 = game.Play(6);
            Assert.Equal("Fizz", p1);
        }

        [Fact]
        public void WypisujeBuzzDlaPiec()
        {
            var p1 = game.Play(5);
            Assert.Equal("Buzz", p1);
        }

        [Fact]
        public void WypisujeBuzzDlaDziesiatki()
        {
            var p1 = game.Play(10);
            Assert.Equal("Buzz", p1);
        }

        [Fact]
        public void DlaObuJestFizzBuzz()
        {
            var p1 = game.Play(15);
            Assert.Equal("FizzBuzz", p1);
        }

        [Fact]
        public void DlaJedynkiZwracaJeden()
        {
            var p1 = game.Play(1);
            Assert.Equal("1", p1);
        }

        [Fact]
        public void DlaCzworkiZwracaCztery()
        {
            var p1 = game.Play(4);
            Assert.Equal("4", p1);
        }
    }
}
