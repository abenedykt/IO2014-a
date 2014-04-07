using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Kwadrat : Prostokat
    {
        public Kwadrat(double a)
            : base(a, a)
        {
        }
    }

    public class Prostokat
    {
        private double a;
        private double b;

        public Prostokat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Obwod()
        {
            return 2 * a + 2 * b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var prostokat = new Prostokat(3, 4);
            Console.WriteLine(prostokat.Obwod());

            var kwadrat = new Kwadrat(4);
            Console.WriteLine(kwadrat.Obwod());

            Console.ReadKey();
        }
    }
}
