using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string Play(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return number.ToString();
        }

        public IEnumerable<string> Range()
        {
            var i = 1;
            while (true)
                yield return Play(i++);
        }

        public IEnumerable<string> Range(int count)
        {
            return Range().Take(count).ToArray();
        }
    }
}
