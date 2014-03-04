using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit; // dodajemy

// TDD - Test Driven Development
// TDD pozwala na prowadzenie dokladnej i aktualnej dokumentacji
// Nazwa powinna okreslac dokladnie testowany fragment kodu
// nie wolno pisac wiecej kodu do testu niz to jest potrzebne
namespace TDD_lab_01
{
    public class Class1
    {
        FizzBuzz game = new FizzBuzz();
        public Class1()
        {
            var game = new FizzBuzz();
        }

        [Fact] // metoda rozpoczynajaca Test
        public void Test() // testowa metoda nic nie zwracajaca
        {
            Assert.True(true);
        }

        [Fact]
        public void WypisujeFizzDlaTrzy()
        {
            var p1 = game.Play(3);
            Assert.Equal("Fizz", p1);
        }

        [Fact]
        public void WypisujeFizzDlaSzostki()
        {
            var p1 = game.Play(6);
            Assert.Equal("Fizz", p1);
        }

        [Fact]
        public void WypisujeBuzzDlaPiec()
        {
            var p1 = game.Play(5);
            Assert.Equal("Buzz", p1);
        }

        [Fact]
        public void WypisujeBuzzDlaDziesiatki()
        {
            var p1 = game.Play(10);
            Assert.Equal("Buzz", p1);
        }

        [Fact]
        public void DlaObuJestFizzBuzz()
        {
            var p1 = game.Play(15);
            Assert.Equal("FizzBuzz", p1);
        }

        [Fact]
        public void DlaJedynkiZwracaJeden()
        {
            var p1 = game.Play(1);
            Assert.Equal("1", p1);
        }

        [Fact]
        public void DlaCzworkiZwracaCztery()
        {
            var p1 = game.Play(4);
            Assert.Equal("4", p1);
        }
    }
}
