using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Kwadrat : Prostokat
    {
        public new int A
        {
            set
            {
                base.A = value;
                base.B = value;
            }

            get { return base.A; }
        }

        public new int B
        {
            set 
            {
                base.A = value;
                base.B = value;
            }

            get { return base.B; }
        }

        public Kwadrat(int a) 
            : base(a, a)
        {
        }
    }

    public class Prostokat
    {
        public int A { get; set; }
        public int B { get; set; }

        public Prostokat(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int ObliczObwod()
        {
            return (2*A + 2*B);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prostokat = new Prostokat(5, 10);
            Console.WriteLine(prostokat.ObliczObwod());

            Console.ReadLine();
        }
    }
}
