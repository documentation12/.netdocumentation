using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace test
{
    public class Shape
    {
        protected double area;
    }

    public class Rectangle : Shape
    {
        private double Length;
        private double Width;

        // Property for Length
        public double length
        {
            get { return Length; }
            set { Length = value; }
        }

        // Property for Width
        public double width
        {
            get { return Width; }
            set { Width = value; }
        }

        // Area method
        public double Area()
        {
            return Length * Width;
        }

        public void setArea()
        {
            area = Area();
        }
    }

    public class Circle : Shape
    {
        private double Radius;

        public double radius
        {
            get { return Radius; }
            set { Radius = value; }
        }

        public double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
