using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo
{
    public class GeoRecord
    {
        public string NrDziałki { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double MinX { get; set; }
        public double MaxX { get; set; }
        public double MinY { get; set; }
        public double MaxY { get; set; }
    }
}
