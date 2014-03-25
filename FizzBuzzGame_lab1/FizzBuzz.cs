using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_lab_01
{
    public class ReturnType
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }
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
                tempCollection.Add(new ReturnType{ ID = i+1, Value = Play(i+1).ToString()});
            }
            return tempCollection;
        } 
        public object Play(int p)
        {
            #region switche

            switch (p % 15)
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

            #endregion
            #region IFy
            //if (p % 15 == 0)
            //{
            //    return "FizzBuzz";
            //}
            //else if(p % 3 == 0)
            //{
            //    return "Fizz";
            //} 
            //else if(p % 5 == 0)
            //{
            //    return "Buzz";
            //}
            //else
            //{
            //    return p.ToString();
            //}
            #endregion
        }
    }
}
