using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
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
            return p.ToString();
        }

        public IEnumerable<string> Range(int p)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= p; i++)
            {
                list.Add(Play(i));
            }
            return list;
        }
    }
}
