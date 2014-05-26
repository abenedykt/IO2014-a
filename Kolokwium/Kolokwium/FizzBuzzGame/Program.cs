using System;
using System.Threading;
using FizzBuzzGame.Models;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }

            FizzBuzz fb = new FizzBuzz();
            int ilosc = int.Parse(args[0]);

            for (int i = 1; i <= ilosc; i++)
            {
                Console.WriteLine(fb.Play(i).ToString());
            }
  
            Console.ReadLine();
        }
    }
}
