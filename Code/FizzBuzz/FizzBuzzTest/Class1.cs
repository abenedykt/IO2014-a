using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class ProgramTest
    {
        [Fact]
        public void WypisujeFizzNaTrzy()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void WypisujeJedenNaJeden()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void WypisujeBuzzNaPiec()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void WypisujeFizzBuzzNaPietnascie()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(15);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void WypisujeOd1Do3()
        {
            var game = new FizzBuzzGame();
            var result = game.Range(3);
            Assert.Equal(new string[] { "1", "2", "Fizz" }, result);
        }
    }
}
