using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TDD_Lab_01;

namespace FissBassConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FissBass(args);

            var saver = new Saver();
            saver.ToTxt(fb.ReturnCollection());
            saver.ToXml(fb.ReturnCollection());
            saver.ToJson(fb.ReturnCollection());


            Console.Read();
        }
    }
}
