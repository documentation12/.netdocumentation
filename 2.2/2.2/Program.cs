using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = 10;
            string itemName = "Widget";
             for (int i = 1; i<6; i++)
            {
                Console.WriteLine(itemName + i);
            }

            Console.WriteLine();

            Employee emp = new Employee("noone", 1000);
            emp.Displayinfo();

            Console.WriteLine();

            Fruit fruit = new Fruit();
            fruit.Weigthinkg = 5;
            fruit.Priceofkg = 10;
            Console.WriteLine(fruit.CalculatePrice());

            Console.WriteLine();

            Electronics elec = new Electronics();
            elec.OneUnitPrice = 20;
            elec.Quantity = 10;
            Console.WriteLine($"Total Price Is: { elec.CalculatePrice()}");

            Console.WriteLine();

            Sparrow sp = new Sparrow();
            Console.WriteLine(sp.MakeSound());

            Console.WriteLine();

            MyCollection<string> coll = new MyCollection<string>();
            coll.AddItem("itemName");
            coll.AddItem("itemName2");
            coll.AddItem("itemName3");

            Console.WriteLine(coll.GetItem(2));



        }
    }
}
