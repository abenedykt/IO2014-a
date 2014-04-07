using Xunit;

namespace Lab_05_LSP
{
    public class FiguryTest
    {
        [Fact]
        public void ObwodKwadratu()
        {
            Kwadrat o = new Prostokat(50,5);

            Assert.Equal(110, o.Obwod());
        }

        [Fact]
        public void ObwodKwadratu2()
        {
            var o = new Kwadrat(5);

            Assert.Equal(20, o.Obwod());
        }

        [Fact]
        public void ObwodProstokata()
        {
            var o = new Prostokat(10, 5);
            Assert.Equal(30,o.Obwod());
        }
    }
}
