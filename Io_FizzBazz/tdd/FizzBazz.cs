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
            //    return "FizzBazz";
            //else if (p % 3 == 0)
            //    return "Fizz";
            //else if (p % 5 == 0)
            //    return "Bazz";
            //else
            //    return p.ToString();
            string ret = "";
            switch (p % 15)
            {
                case 0:
                    ret = "FizzBazz";
                    break;
                case 3:
                case 6:
                case 9:
                    ret = "Fizz";
                    break;
                case 5:
                case 10:
                    ret = "Bazz";
                    break;
                default:
                    ret = p.ToString();
                    break;
            }
            return ret;
        }
    }
}
