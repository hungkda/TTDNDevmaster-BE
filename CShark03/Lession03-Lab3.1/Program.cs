using Lession03_Lab3._1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Car car = new Car();
        car.make = "FFFF";
        car.model = "MR2";
        car.color = "white";
        car.year = 1999;
        //display
        Console.WriteLine("Thông itn chi tiết");
        Console.WriteLine("make: " + car.make);
        Console.WriteLine("model: " + car.model);
        Console.WriteLine("color: " + car.color);
        Console.WriteLine("year: " + car.year);
        car.Start();
        car.Stop();
    }
}