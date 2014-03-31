using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserGeo.Model
{
    public class Position
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static bool operator==(Position pos1, Position pos2)
        {
            return (pos1.X == pos2.X && pos1.Y == pos2.Y);
        }

        public static bool operator !=(Position pos1, Position pos2)
        {
            return !(pos1 == pos2);
        }
    }
}
