using System;

namespace LSP
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            IOperacje k1 = new Kwadrat(2);
            
            Console.WriteLine("Obwod kwadratu: " + ObliczObwod().ToString());
            Console.WriteLine("Pole kwadratu: " + k1.Obwod());

            var p1 = new Prostokat(2,4);

            Console.WriteLine("Obwod prostokata: " + p1.Obwod());
            Console.WriteLine("Pole prostokata: " + p1.Pole());

            Console.ReadLine();
        }

        private double ObliczObwod(IOperacje k1)
        {
            return k1.Obwod();
        }
    }

    public interface IOperacje
    {
        double Obwod();
        double Pole();
    }

    public class Kwadrat : IOperacje
    {
        public double Bok { get; set; }
        public Kwadrat(double a)
        {
            this.Bok = a;
        }

        public virtual double Obwod()
        {
            return 4*this.Bok;
        }

        public virtual double Pole()
        {
            return 2*this.Bok + 2*this.Bok;
        }
    }

    public class Prostokat : IOperacje
    {
        public readonly double BokA;
        public readonly double BokB;

        public Prostokat(double a, double b)
        {
            this.BokA = a;
            this.BokB = b;
        }

        public virtual double Obwod()
        {
            return 2*BokA + 2*BokB;
        }

        public virtual double Pole()
        {
            return BokA*BokB;
        }
    }
}
