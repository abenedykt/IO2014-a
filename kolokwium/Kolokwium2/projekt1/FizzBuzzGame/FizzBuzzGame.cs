using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzGameTests
{
    public class FizzBuzzGame
    {
        public string Play(int p)
        {
            string toShow = "";
            if (p % 3 == 0) toShow += "Fizz";
            if (p % 5 == 0) toShow += "Buzz";

            if (toShow == "") toShow += p.ToString();

            return toShow;
        }

        public IEnumerable<string> Range(int p)
        {
            for (int i = 1; i <= p; i++)
            {
                yield return Play(i);
            }
        }
    }
}
