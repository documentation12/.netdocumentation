using System;

namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string name = "John";
            for (int i = 1; i<11; i++)
            {
                Console.WriteLine($"{name} {i}");
            }

            Person person = new Person(age, name);
            Console.WriteLine(person.Introduction());

            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width = 20;
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
            Circle circle = new Circle();
            circle.Radius = 10;
            Console.WriteLine($"Circle Area: {circle.GetArea()}");

            car car = new car();
            car.startEngine();
            bike bike = new bike();
            bike.startEngine();

            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Get(1));


        }
    }
}
