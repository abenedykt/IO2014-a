using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp
{
    public class Prostokat
    {
        public readonly int A;
        public readonly int B;

        public Prostokat(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int Obwod()
        {
            return 2 * A + 2 * B;
        }

        public int Pole()
        {
            return A * B;
        }
    }

    public class Kwadrat : Prostokat
    {
        public Kwadrat(int a)
            : base(a, a)
        {
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            var prostokat = new Kwadrat(10);

            Console.WriteLine(prostokat.Obwod());

            Console.ReadKey(true);
        }
    }
}
