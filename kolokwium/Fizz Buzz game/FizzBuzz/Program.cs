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
            if (n % 3 == 0 && n % 5 == 0)
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
            } else {
                return n.ToString();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
