namespace TDD_Lab_02
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

        protected bool Equals(GeoRecord other)
        {
            return
                string.Equals(NrDziałki, other.NrDziałki) &&
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
                var hashCode = (NrDziałki != null ? NrDziałki.GetHashCode() : 0);
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