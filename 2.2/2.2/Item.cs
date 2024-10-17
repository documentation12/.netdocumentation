using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    public class Item
    {
        protected double Price {  get; set; }

        public Item()
        {
            Price = 0;
        }

        public virtual double CalculatePrice()
        {
            return Price;
        }
    }

    public class Fruit : Item
    {
        private float weightinkg;
        private float priceofkg;

        public float Weigthinkg
        {
            get { return weightinkg; }
            set { weightinkg = value; }

        }

        public float Priceofkg
        {
            get { return priceofkg; }
            set { priceofkg = value; }

        }

        public override double CalculatePrice()
        {
            return weightinkg * priceofkg;
        }


    }

    public class Electronics : Item
    {
        private int quantity;
        private double oneUnitPrice;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double OneUnitPrice
        {
            get { return oneUnitPrice; }
            set { oneUnitPrice = value; }
        }

        public override double CalculatePrice()
        {
            return oneUnitPrice * quantity;
        }
    }
}
