using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tdd
{
    public class FizzBazz
    {
        public string Play(int p)
        {
            //if (p % 15 == 0)
            //    return "FIZZBUZZ";
            //else if (p % 3 == 0)
            //    return "FIZZ";
            //else if (p % 5 == 0)
            //    return "BUZZ";
            //else
            //    return p.ToString();
            string ret = "";
            switch (p % 15)
            {
                case 0:
                    ret = "FIZZBUZZ";
                    break;
                case 3:
                case 6:
                case 9:
                    ret = "FIZZ";
                    break;
                case 5:
                case 10:
                    ret = "BUZZ";
                    break;
                default:
                    ret = p.ToString();
                    break;
            }
            return ret;
        }
    }
}
