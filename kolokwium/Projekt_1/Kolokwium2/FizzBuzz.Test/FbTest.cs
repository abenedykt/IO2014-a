using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FizzBuzz.Game;

namespace FizzBuzz.Test
{
    public class FbTest
    {
        FizzBuzzGame game = new FizzBuzzGame();
        public FbTest()
        {
            game = new FizzBuzzGame();
        }
        [Fact]
        public void CzyDlaTrojkiJestFizz()
        {
            var p1 = game.Play(3);
            Assert.Equal("Fizz", p1);
        }

        [Fact]
        public void CzyDlaPodzielnejPrzezTrzyJestFizz()
        {
            var p1 = game.Play(6);
            Assert.Equal("Fizz", p1);
        }

        [Fact]
        public void CzyDlaPiatkiJestBuzz()
        {
            var p1 = game.Play(5);
            Assert.Equal("Buzz", p1);
        }
        [Fact]
        public void CzyDlaPietnastkiJestFizzBuzz()
        {
            var p1 = game.Play(15);
            Assert.Equal("FizzBuzz", p1);
        }

    }
}
