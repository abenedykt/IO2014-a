using System;
using System.Collections.Generic;

namespace FizzBuzz.Game
{
    public class ReturnType
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }
    public class FizzBuzzGame
    {
        public int N { get; set; }
        public FizzBuzzGame()
        {
               
        }
        public FizzBuzzGame(string[] args)
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
            switch (p % 15)
            {
                case 0: return "FizzBuzz";
                case 3: return "Fizz";
                case 6: return "Fizz";
                case 5: return "Buzz";
                case 10: return "Buzz";
                case 9: return "Fizz";
                case 12: return "Fizz";
                default: return p;
            }
         
        }
    }
}
