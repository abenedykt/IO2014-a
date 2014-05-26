using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using projekt1;

namespace projekt2
{
    public class Testy
    {
        [Fact]
        public void TestDla3()
        {
            FizzBazz fb = new FizzBazz();
            string exp = "Fizz";
            string res = fb.Play(3);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestDla5()
        {
            FizzBazz fb = new FizzBazz();
            string exp = "Bazz";
            string res = fb.Play(5);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestDla15()
        {
            FizzBazz fb = new FizzBazz();
            string exp = "Fizz Bazz";
            string res = fb.Play(15);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestDla2()
        {
            FizzBazz fb = new FizzBazz();
            string exp = "2";
            string res = fb.Play(2);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestDla11()
        {
            FizzBazz fb = new FizzBazz();
            string exp = "11";
            string res = fb.Play(11);
            Assert.Equal(exp, res);
        }
    }
}
