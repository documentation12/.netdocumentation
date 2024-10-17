using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = 20;
            string city = "Tbilisi";
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{city}-{i}-{temperature * 9 / 5 + 32}");
            }

            Console.WriteLine();

            Student st = new Student("name", 20);
            Console.WriteLine(st.Greeting());


            Console.WriteLine();

            Triangle tr = new Triangle();
            double trarea = tr.CalculateArea(5.0, 10.0);
            Console.WriteLine($"Triangle area is {trarea}");

            Console.WriteLine();

            Square sq = new Square();
            double sqarea = sq.CalculateArea(10.0);
            Console.WriteLine(sqarea);

            Console.WriteLine();

            Triangle_ tr1 = new Triangle_();
            tr1._Height = 10.5;
            tr1._Base = 11;
            Console.WriteLine(tr1.CalculateArea());

            Console.WriteLine();

            Dog dog = new Dog();
            dog.makesound();

            MyCollection<string> myCollection = new MyCollection<string>();


            myCollection.AddItem("st1");
            myCollection.AddItem("st2");
            myCollection.AddItem("st3");
            myCollection.AddItem("st4");

            Console.WriteLine(myCollection.Getstring(3));
 
        }
    }
}
