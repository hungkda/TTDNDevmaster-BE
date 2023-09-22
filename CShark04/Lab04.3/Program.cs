using Lab04._3;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Rectangle rec = new Rectangle();
        rec.InputData();
        Console.WriteLine("Diện tích hình chữ nhật là: {0:N}", rec.Area());
        Console.WriteLine("Chu vi hình chữ nhật là: {0:N}", rec.Circumference());

        Circle cir = new Circle();
        cir.InputData();
        Console.WriteLine("Diện tích hình tròn là: {0:N}", cir.Area());
        Console.WriteLine("Chu vi hình tròn là: {0:N}", cir.Circumference());

    }
}