using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class FissBass
    {
        public object Play(int p)
        {
            switch (p%15) 
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
    }
}
