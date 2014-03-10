using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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

        public override bool Equals(object obj)
        {
            GeoRecord that = obj as GeoRecord;
            if (that == null)
                return false;

            return
                this.NrDziałki == that.NrDziałki &&
                this.X == that.X &&
                this.Y == that.Y &&
                this.MinX == that.MinX &&
                this.MaxX == that.MaxX &&
                this.MinY == that.MinY &&
                this.MaxY == that.MaxY;
        }
    }
}
