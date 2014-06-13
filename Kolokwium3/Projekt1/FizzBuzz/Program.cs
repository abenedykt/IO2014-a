using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var game = new FizzBuzzGame();
            var result = game.Range(count);

            Console.WriteLine();
            foreach (var item in result)
                Console.WriteLine(item);

            File.WriteAllLines(@"C:\Users\student\Desktop\IO\FizzBuzz\result.txt", result.ToArray());

            Console.ReadKey(true);
        }
    }
}
