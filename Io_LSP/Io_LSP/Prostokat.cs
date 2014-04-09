using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Io_LSP
{
    public class Prostokat
    {
        private double p;
        private double q;

        public Prostokat(double p, double q)
        {
            if (p <= 0 || q <= 0)
                throw new Exception("Boki muszą być większe od zera!");
            this.p = p;
            this.q = q;
        }

        public double Obwod()
        {
            return p * q;
        }
    }
}
