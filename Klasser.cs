using System;

namespace Övning2._4

{
    interface IArea
    {
        double BeräknaArea();
    }

    class Figur
    {
        public double bredd;
        public double höjd;

        public Figur(double bredd, double höjd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }
    }

    class Triangel : Figur, IArea
    {
        public Triangel(double bredd, double höjd) : base(bredd, höjd) { }
        public double BeräknaArea()
        {
            return (bredd * höjd) / 2;
        }
        public override string ToString()
        {
            return "Triangel: " + bredd + "x" + höjd;
        }
    }

    class Cirkel : Figur, IArea
    {
        public Cirkel(double bredd, double höjd) : base(bredd, höjd) { }
        public double BeräknaArea()
        {
            return Math.Pow((bredd / 2), 2) * Math.PI;
        }
        public override string ToString()
        {
            return "Cirkel: " + bredd + "x" + bredd;
        }
    }

    class Linje : Figur
    {
        public Linje(double bredd, double höjd) : base(bredd, höjd) { }
        public override string ToString()
        {
            return "Linje: " + bredd + "x" + höjd;
        }
    }
}