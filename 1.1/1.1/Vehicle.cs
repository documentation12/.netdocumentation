using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    public abstract class Vehicle
    {
        public abstract void startEngine();

    }

    public class car : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Car engine started");
        }
    }

    public class bike : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Bike engine started");
        }
    }
}
