using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    public class FizzBazz
    {
        public string Play(int p)
        {
            if (p % 15 == 0)
                return "Fizz Bazz";
            else if (p % 5 == 0)
                return "Bazz";
            else if (p % 3 == 0)
                return "Fizz";
            else
                return p.ToString();
        }
    }
}
