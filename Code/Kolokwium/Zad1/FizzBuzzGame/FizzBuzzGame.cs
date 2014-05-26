using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string Play(int n)
        {
            if (n % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (n % 3 == 0)
            {
                return "Fizz";
            }
            else if (n % 5 == 0)
            {
                return "Buzz";
            }
            return n.ToString();
        }

        public IEnumerable<string> Range(int n)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(Play(i));
            }
            return list;
        }
    }
}
