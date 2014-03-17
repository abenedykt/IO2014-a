using MsTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MsTest_Test
{
    public class Class1
    {
        [Fact]
        public void WypisujFizzDla1()
        {
            var game = new FizzBuzz();

            var result = game.Play(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void WypisujeBuzzDlaPodzielnejPrzez5()
        {
            var game = new FizzBuzz();

            var result = game.Play(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void WypisujeFizzDlaPodzielnejPrzez3()
        {
            var game = new FizzBuzz();

            var result = game.Play(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void WypisujeFizzBuzzDlaPodzielnejPrzez15()
        {
            var game = new FizzBuzz();

            var result = game.Play(30);

            Assert.Equal("FizzBuzz", result);
        }


    }
}
