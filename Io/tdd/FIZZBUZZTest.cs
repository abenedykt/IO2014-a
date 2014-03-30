using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tdd
{
    public class FIZZBUZZTest
    {
        [Fact]
        public void Wypisuje1Dla1()
        {
            var game = new FizzBazz();
            string res = "";
            res = game.Play(1);
            Assert.Equal("1", res);
        }

        [Fact]
        public void WypisujeFIZZDla3()
        {
            var game = new FizzBazz();
            string res = "";
            res = game.Play(3);
            Assert.Equal("FIZZ", res);
        }

        [Fact]
        public void WypisujeBUZZDla5()
        {
            var game = new FizzBazz();
            string res = "";
            res = game.Play(5);
            Assert.Equal("BUZZ", res);
        }

        [Fact]
        public void WypisujeFIZZBUZZDla15()
        {
            var game = new FizzBazz();
            string res = "";
            res = game.Play(15);
            Assert.Equal("FIZZBUZZ", res);
        }
    }
}
