using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    public abstract class Animal
    {
        public abstract void makesound(); 
    }

    public class Dog : Animal
    {
        public override void makesound()
        {
            Console.WriteLine("Woof");
        }
    }
}
