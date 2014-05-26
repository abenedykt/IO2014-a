namespace IOv222
{
    public class TestyDoFizzBazz
    {
        [Fact]
        public void Powiedzial3()
        {
            var game = new FizzBazz();
            var wynik = game.Next(3);
            Assert.Equal("Fizz", wynik);

        }
        [Fact]
        public void Powiedzial5()
        {
            var game = new FizzBazz();
            var wynik = game.Next(5);
            Assert.Equal("Bazz", wynik);
        }
        [Fact]
        public void Powiedzial15()
        {
            var game = new FizzBazz();
            var wynik = game.Next(15);
            Assert.Equal("FizzBazz", wynik);
        }
        [Fact]
        public void PowiedzialInna()
        {
            var game = new FizzBazz();
            var wynik = game.Next(4);
            Assert.Equal(4, wynik);
        }



    }
}
