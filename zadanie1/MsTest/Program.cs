using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new FizzBuzz();

            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            var result = game.PlayRange(number);

            

            using (StreamWriter stream = new StreamWriter(@"D:\IO\MsTest\test.txt"))
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                    stream.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
