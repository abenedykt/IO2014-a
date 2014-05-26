using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Wypisuje1na1()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void WypisujeFizzna3()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void WypisujeBuzzna5()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void WypisujeFizzBuzzna15()
        {
            var game = new FizzBuzzGame();
            var result = game.Play(15);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void TestDlaMetodyRange()
        {
            var game = new FizzBuzzGame();
            var result = game.Range(5);
            Assert.Equal(new string[] {"1", "2", "Fizz", "4", "Buzz"}, result);
        }
    }
}
