using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucja1
{
    public class FizzBuzzGame
    {
        public string Play(int p)
        {
            if (p % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (p % 3 == 0)
            {
                return "Fizz";
            }
            else if (p % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return p.ToString();
            }
        }

        public IEnumerable<string> PlayRange(int count)
        {
            var list = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                list.Add(this.Play(i));
            }

            return list;
        }
    }
}
