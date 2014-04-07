using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwadratProstokatLogic
{
    public class Prostokat : IFigure
    {
        public int A { get; set; }
        public int B { get; set; }

        public Prostokat(int a, int b)
        {
            A = a;
            B = b;

        }

        public double perimeter()
        {
            return 2 * A + 2 * B;
        }
    }
}
