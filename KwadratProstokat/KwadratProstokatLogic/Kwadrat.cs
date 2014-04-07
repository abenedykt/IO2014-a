using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwadratProstokatLogic
{
    public class Kwadrat : IFigure
    {
        public int A { get; set; }

        public Kwadrat(int a)
        {
            A = a;
        }

        public double perimeter()
        {
            return 4*A;
        }
    }
}
