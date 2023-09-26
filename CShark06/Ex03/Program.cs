using Ex03;
using System.Globalization;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<Car> cars = new List<Car>()
        {
            new Car() {Name = "Toyata", Color = "White"},
            new Car() {Name = "Toyata", Color = "Black"},
            new Car() {Name = "Toyata", Color = "Red"},
            new Car() {Name = "Toyata", Color = "Custom"},
            new Car() {Name = "Toyata", Color = "Pink"},
            new Car() {Name = "Mec", Color = "White"},
            new Car() {Name = "Mec", Color = "Black"},
            new Car() {Name = "Mec", Color = "Red"},
            new Car() {Name = "Mec", Color = "Custom"},
            new Car() {Name = "Mec", Color = "Pink"},
        };

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        int carRemove = cars.RemoveAll(car => String.Compare(car.Color, "Red", CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase) == 0);
        Console.WriteLine($"Đã xóa {carRemove} xe màu đỏ");
        Console.WriteLine("List Car sau xoa:");

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}