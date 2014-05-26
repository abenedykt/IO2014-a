using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public string Compute(int i)
        {
            if (i % 15 == 0)
                return "FizzBuzz";
            if (i % 3 == 0)
                return "Fizz";
            if (i % 5 == 0)
                return "Buzz";

            return i.ToString();
        }

        public IEnumerable<string> ComputeSequence()
        {
            var i = 1;
            while (true)
                yield return Compute(i++);
        }
    }
}
