namespace Lab_05_LSP
{
    public class Kwadrat
    {
        protected int BokA { get; private set; }


        public Kwadrat(int bokA)
        {
            BokA = bokA;
        }

        public virtual int Obwod()
        {
            return (4 * BokA);
        }
    }

    public class Prostokat : Kwadrat
    {
        private int BokB { get; set; }

        public Prostokat(int bokA, int bokB)
            : base(bokA: bokA)
        {
            BokB = bokB;
        }
        public override int Obwod()
        {
            return (2 * BokA + 2 * BokB);
        }
    }
}
