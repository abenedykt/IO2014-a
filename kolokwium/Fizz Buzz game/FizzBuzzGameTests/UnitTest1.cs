using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzGameTests
{
    public class UnitTest1
    {
        [Fact]
        public void Return1For1()
        {
            var g = new FizzBuzzGame();
            var result = g.Play(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void ReturnFizzFor3()
        {
            var g = new FizzBuzzGame();
            var result = g.Play(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ReturnBuzzFor5()
        {
            var g = new FizzBuzzGame();
            var result = g.Play(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ReturnFizzBuzzFor15()
        {
            var g = new FizzBuzzGame();
            var result = g.Play(15);
            Assert.Equal("FizzBuzz", result);
        }
    }
}
