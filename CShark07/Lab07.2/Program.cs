internal class Program
{
    private static void Main(string[] args)
    {
        Business.House h = new Business.House();

        h.HouseNo = "DDDDDDDDDDDDDDD";
        h.Price = 100999;

        Console.WriteLine("House Details: ");
        Console.WriteLine("\tHouse No: " + h.HouseNo);
        Console.WriteLine("\tPrice: " + h.Price);

        Business.Dealerhip.Car c = new Business.Dealerhip.Car();
        c.CarNo = "D000";
        c.Price = 98648;
        Console.WriteLine("Car Details: ");
        Console.WriteLine("\tCar No: " + c.CarNo);
        Console.WriteLine("\tPrice: " + c.Price);
    }
}