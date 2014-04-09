using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Io_LSP
{
    [TestFixture]
    public class Testy
    {
        [Test]
        public void Prostokat2i3Test()
        {
            Prostokat prostokat = new Prostokat(2.0, 3.0);
            Assert.AreEqual(6, prostokat.Obwod());
        }

        [Test]
        public void ProstokatMinus2i3Test()
        {
            Assert.Throws<Exception>(() => new Prostokat(-2.0, 3.0));
        }

        [Test]
        public void Prostokat2iMinus3Test()
        {
            Assert.Throws<Exception>(() => new Prostokat(2.0, -3.0));
        }

        [Test]
        public void ProstokatMinus2iMinus3Test()
        {
            Assert.Throws<Exception>(() => new Prostokat(2.0, -3.0));
        }

        [Test]
        public void Kwadrat4Test()
        {
            Kwadrat kwadrat = new Kwadrat(4);
            Assert.AreEqual(16, kwadrat.Obwod());
        }

        [Test]
        public void Kwadrat0Test()
        {
            Kwadrat kwadrat = new Kwadrat(4);
            Assert.Throws<Exception>(() => new Kwadrat(0));
        }

        [Test]
        public void KwadratMinus1Test()
        {
            Kwadrat kwadrat = new Kwadrat(4);
            Assert.Throws<Exception>(() => new Kwadrat(-1));
        }

        [Test]
        public void KwadratJakoProstokat4Test()
        {
            Prostokat kwadrat = new Kwadrat(4);
            Assert.AreEqual(16, kwadrat.Obwod());
        }
    }
}
