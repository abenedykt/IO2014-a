using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD_Lab_01
{
    public class Class1
    {
        FissBass game = new FissBass();
        public Class1()
        {
            game = new FissBass();
        }
        [Fact]
        public void CzyDlaTrojkiJestFiss()
        {
            var p1 = game.Play(3);
            Assert.Equal("Fiss", p1);
        }

        [Fact]
        public void CzyDlaPodzielnejPrzezTrzyJestFiss()
        {
            var p1 = game.Play(6);
            Assert.Equal("Fiss", p1);
        }

        [Fact]
        public void CzyDlaPiatkiJestBass()
        {
            var p1 = game.Play(5);
            Assert.Equal("Bass", p1);
        }

        [Fact]
        public void CzyDlaPodzielnejPrzezPiecJestBass()
        {
            var p1 = game.Play(10);
            Assert.Equal("Bass", p1);
        }
        [Fact]
        public void CzyDlaObuJestFissBass()
        {
            var p1 = game.Play(15);
            Assert.Equal("FissBass", p1);
        }
        [Fact]
        public void CzyJedynkiJestJeden()
        {
            var p1 = game.Play(1);
            Assert.Equal(1, p1);
        }
    }
}
