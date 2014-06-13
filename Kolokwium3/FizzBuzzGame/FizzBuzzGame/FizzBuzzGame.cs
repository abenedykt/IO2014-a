using System.Globalization;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public string GetVal(int val)
        {
            if (val == 0) return "0";
            if (val%5 == 0 && val%3 == 0) return "FizzBuzz";
            if (val%3 == 0) return "Fizz";
            return val%5 == 0 ? "Buzz" : val.ToString(CultureInfo.InvariantCulture);
        }
    }
}
