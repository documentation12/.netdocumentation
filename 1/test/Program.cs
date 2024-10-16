namespace test
{ 
class Program
{
    static void Main()
    {

        int myAge = 20;
        double bankBalance = 100.50;
        if (bankBalance >= 1000)
        {
            Console.WriteLine("health balance");
        }
        else { Console.WriteLine("bad balance"); }


        Rectangle rectangle = new Rectangle();
        rectangle.length = 10;
        rectangle.width = 20;
        Console.WriteLine("Area of Rectangle: " + rectangle.Area());

        Circle circle = new Circle();
        circle.radius = 10;
        Console.WriteLine("Area of Circle: " + circle.Area());

        Person person = new Person(20, "John");

        Console.WriteLine(person.printDetails());

        
    }
}
}
