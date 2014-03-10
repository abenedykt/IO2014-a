using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Zad2Dzialki
{
    class GeoRecord
    {
        public string nrDzialki;
        public string x;
        public string y;
        public string minX;
        public string maxX;
        public string minY;
        public string maxY;

        public GeoRecord(IGeoFileReader reader, IGeoRepository repository)
        {
            
        }
    }
}
