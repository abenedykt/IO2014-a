using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class GeoRecord
    {

        public string NrDzialki { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double MinX { get; set; }
        public double MinY { get; set; }
        public double MaxX { get; set; }
        public double MaxY { get; set; }

        public GeoRecord(string nrDzialki, double x, double y, double minX, double minY, double maxX, double maxY)
        {
            NrDzialki = nrDzialki;
            X = x;
            Y = y;
            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }
    }
}
