using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace _3._3
{
    public class Figur
    {
        protected double Area { get; set; }

        public Figur()
        {
            Area = 0.0;
        }

        public virtual double CalculateArea()
        {
            return Area;
        }
    }

    public class Triangle_ : Figur
    {
        private double _base;
        private double _height;

        public double _Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double _Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public override double CalculateArea()
        {
            Area = (_Base * _Height) / 2;
            return Area;
        }
    }

    public class Square_ : Figur
    {
        private double sideLength;

        public double SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }


        public override double CalculateArea()
        {
            Area = SideLength * SideLength;
            return Area;
        }
    }
}
