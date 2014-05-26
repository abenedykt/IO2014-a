using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzzGame
    {
        public string Play(int i)
        {
            string toOutput = "";
            if (i % 3 == 0) toOutput = "Fizz";
            if (i % 5 == 0) toOutput += "Buzz";
            if (toOutput == String.Empty) return i.ToString();

            return toOutput;
        }

        public IEnumerable<string> PlayRange(int i)
        {
            return Enumerable.Range(1, i).Select(Play);
        }
    }
}
