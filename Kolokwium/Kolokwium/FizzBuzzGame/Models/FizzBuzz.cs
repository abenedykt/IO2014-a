using System;
using System.Collections.Generic;

namespace FizzBuzzGame.Models
{
    public class FizzBuzz
    {
        public int N { get; set; }

        public FizzBuzz()
        {

        }

        public FizzBuzz(string[] args)
        {
            N = Convert.ToInt32(args[0]);
        }

        public IEnumerable<ReturnType> ReturnCollection()
        {
            var tempCollection = new List<ReturnType>();
            for (int i = 0; i < N; i++)
            {
                tempCollection.Add(new ReturnType { ID = i + 1, Value = Play(i + 1).ToString() });
            }
            return tempCollection;
        }


        public object Play(int p)
        {
            switch (p%15)
            {
                case 0:
                    return "FizzBuzz";
                case 3:
                    return "Fizz";
                case 6:
                    return "Fizz";
                case 5:
                    return "Buzz";
                case 10:
                    return "Buzz";
                default:
                    return p.ToString();
            }
        }
    }
}
