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
        public double MaxX { get; set; }
        public double MinY { get; set; }
        public double MaxY { get; set; }

        public GeoRecord(string nrDzialki, double x, double y, double minX, double maxX, double minY, double maxY)
        {
            this.NrDzialki = nrDzialki;
            this.X = x;
            this.Y = y;
            this.MinX = minX;
            this.MaxX = maxX;
            this.MinY = minY;
            this.MaxY = maxY;
        }
    }
}
