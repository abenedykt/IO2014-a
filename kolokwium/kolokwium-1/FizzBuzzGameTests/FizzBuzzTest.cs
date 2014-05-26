using FizzBuzzGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzGameTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ReturnOneOnOne()
        {
            var result = new FizzBuzz().Compute(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void ReturnTwoOnTwo()
        {
            var result = new FizzBuzz().Compute(2);

            Assert.Equal("2", result);
        }

        [Fact]
        public void ReturnFizzOnThree()
        {
            var result = new FizzBuzz().Compute(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ReturnBuzzOnFive()
        {
            var result = new FizzBuzz().Compute(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ReturnFizzBuzzOnFifteen()
        {
            var result = new FizzBuzz().Compute(15);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void TestFirstFiveNumbers()
        {
            var result = new FizzBuzz().ComputeSequence().Take(5).ToList();

            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };

            Assert.Equal(expected, result);
        }
    }
}
