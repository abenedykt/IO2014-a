using Xunit;
using FizzBuzzGame;

namespace FizzBuzzGameTests
{
    public class Tests
    {
        [Fact]
        public void ZeroTest()
        {

            var fizzBuzz = new FizzBuzz();

            Assert.Equal("0", fizzBuzz.GetVal(0));
        }

        [Fact]
        public void OneTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("1" , fizzBuzz.GetVal(1));
        }

        [Fact]
        public void ThreeTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Fizz", fizzBuzz.GetVal(3));
        }

        [Fact]
        public void FiveTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Buzz", fizzBuzz.GetVal(5));
        }

        [Fact]
        public void FifteenTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("FizzBuzz", fizzBuzz.GetVal(15));
        }

        [Fact]
        public void TwentyTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Buzz", fizzBuzz.GetVal(20));
        }

        [Fact]
        public void NineHundretNityNineTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Fizz", fizzBuzz.GetVal(999));
        }

        [Fact]
        public void TestThatShouldNotPass()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Gandalf", fizzBuzz.GetVal(666));
        }

    }
}
