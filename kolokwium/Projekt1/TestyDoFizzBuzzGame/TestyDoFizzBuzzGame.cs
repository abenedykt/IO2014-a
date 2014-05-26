using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FizzBuzzGame;

namespace TestyDoFizzBuzzGame
{
   public class TestyDoFizzBuzzGame
    {
        [Fact]
        public void FizzBuzzForFive()
        {

            FizzBuzzGame.FizzBuzzGame fb = new FizzBuzzGame.FizzBuzzGame();

            string result = fb.Play(5);

            Assert.Equal("Buzz", result);

        }

        [Fact]
        public void FizzBuzzForThree()
        {

            FizzBuzzGame.FizzBuzzGame fb = new FizzBuzzGame.FizzBuzzGame();

            string result = fb.Play(3);

            Assert.Equal("Fizz", result);

        }

        [Fact]
        public void FizzBuzzForFiveThree()
        {

            FizzBuzzGame.FizzBuzzGame fb = new FizzBuzzGame.FizzBuzzGame();

            string result = fb.Play(15);

            Assert.Equal("FizzBuzz", result);

        }

        [Fact]
        public void FizzBuzzForOther()
        {

            FizzBuzzGame.FizzBuzzGame fb = new FizzBuzzGame.FizzBuzzGame();

            string result = fb.Play(26);

            Assert.Equal("26", result);

        }

        [Fact]
        public void FizzBuzzRange()
        {

            FizzBuzzGame.FizzBuzzGame fb = new FizzBuzzGame.FizzBuzzGame();

            string[] results = fb.PlayRange(15).ToArray();

            string[] expected = new string[]
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
            };

            Assert.Equal(expected, results);


        }
    }
}
