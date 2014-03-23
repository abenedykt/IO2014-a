namespace TDD_Lab_02
{
    public class GeoRecord
    {
        public string NrDzialki { private get; set; }
        public double X { private get; set; }
        public double Y { private get; set; }
        public double MinX { private get; set; }
        public double MaxX { private get; set; }
        public double MinY { private get; set; }
        public double MaxY { private get; set; }

        private bool Equals(GeoRecord other)
        {
            return
                string.Equals(NrDzialki, other.NrDzialki) &&
                X.Equals(other.X) &&
                Y.Equals(other.Y) &&
                MinX.Equals(other.MinX) &&
                MaxX.Equals(other.MaxX) &&
                MinY.Equals(other.MinY) &&
                MaxY.Equals(other.MaxY);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((GeoRecord)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (NrDzialki != null ? NrDzialki.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ MinX.GetHashCode();
                hashCode = (hashCode * 397) ^ MaxX.GetHashCode();
                hashCode = (hashCode * 397) ^ MinY.GetHashCode();
                hashCode = (hashCode * 397) ^ MaxY.GetHashCode();
                return hashCode;
            }
        }
    }
}