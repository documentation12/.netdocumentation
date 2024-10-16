using quiz2;

public class Program
{
    public static void Main(string[] args)
    {
        var int1 = new DataHandler<int>();
        int1.AddData(10);
        int1.AddData(20);
        int1.AddData(30);
        Console.WriteLine(int1.RetrieveData(0)); 

        var tv = new DeviceController("TV");
        tv.Activate(); 

        Vehicle car = new Car();
        car.StartEngine(); 
        car.Accelerate();  

        Vehicle bike = new Bike();
        bike.StartEngine(); 
        bike.Accelerate(); 
    }
}