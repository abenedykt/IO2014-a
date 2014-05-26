namespace lab2_wpf
{
    class FizzBazz
    {
        public object Next(int p)
        {
            if (p % 15 == 0)
                return "FizzBazz";
            else if (p % 5 == 0)
                return "Bazz";
            else if (p % 3 == 0)
                return "Fizz";
            else return p;
        }
    }
        
}
