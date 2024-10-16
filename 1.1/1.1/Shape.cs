namespace _1._1
{
    public class Shape
    {
        protected double Area { get; set; }

        public Shape()
        {
            Area = 0;
        }

        public virtual double GetArea()
        {
            return Area;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public override double GetArea()
        {
            Area = length * width;
            return Area;
        }

    }

    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override double GetArea()
        {
            Area = 3.14 * radius * radius;
            return Area;
        }
    }


}
