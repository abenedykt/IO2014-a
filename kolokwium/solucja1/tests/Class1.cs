using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solucja1;
using Xunit;

namespace tests
{
    public class Class1
    {
        [Fact]
        public void WypisujeJedenNaJeden()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void WypisujeFizzNaTrzy()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(3);
            Assert.Equal("Fizz", result);
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
        public void TestOd1Do5()
        {
            var game = new FizzBuzzGame();
            var expected = new string[] { "1", "2", "Fizz", "4", "Buzz" };
            var result = game.PlayRange(5);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestOd1Do3()
        {
            var game = new FizzBuzzGame();
            var expected = new string[] { "1", "2", "Fizz" };
            var result = game.PlayRange(3);
            Assert.Equal(expected, result);
        }
    }
}
