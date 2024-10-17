using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace _3._3
{
    public class Figure
    {
        protected double Area { get; set; }

        public Figure()
        {
            Area = 0.0;
        }

        public virtual double CalculateArea(double x, double y)
        {
            return Area;
        }
    }

    public class Triangle : Figure
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

        public override double CalculateArea(double _base, double _height)
        {
            _Base = _base;
            _Height = _height;
            Area = (_Base * _Height) / 2;
            return Area;
        }
    }

    public class Square : Figure
    {
        private double sideLength;

        public double SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }


        public override double CalculateArea(double sideLength, double x= 0)
        {
            SideLength = sideLength; 
            Area = SideLength * SideLength;
            return Area;
        }
    }
}
