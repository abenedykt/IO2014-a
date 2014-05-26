using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FissBass
{
      
    class Program
    {
        static object Play(int p)
        {
            switch (p % 15)
            {
                case 0:
                    return "Fiss Bass";
                case 3:
                    return "Fiss";
                case 6:
                    return "Fiss";
                case 5:
                    return "Bass";
                case 10:
                    return "Bass";
                case 9:
                    return "Fiss";
                case 12:
                    return "Fiss";

                default:
                    return p;
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sr = new StreamWriter("plik.txt");
            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.WriteLine(Play(i).ToString());
                sr.WriteLine(Play(i).ToString());
            }
            sr.Close();
        }
    }

}
