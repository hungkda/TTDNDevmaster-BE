using System.ComponentModel.Design;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double a, b, c, dental, x1, x2;
        
        do
        {
            Console.Write("Nhập a: ");

            a = Convert.ToDouble(Console.ReadLine());
        } while (a == 0);
        Console.Write("Nhập b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập c: ");
        c = Convert.ToDouble(Console.ReadLine());

        dental = b * b - (4 * a * c);
        if(dental>0)
        {
            x1 = (-b + Math.Sqrt(dental)) / (2 * a);
            x2 = (-b - Math.Sqrt(dental)) / (2 * a);

            Console.WriteLine("Phương trình có 2 nghiệm phân biệt là x1={0}, x2={1}", x1, x2);
        }else if (dental == 0) {
            x1 = -b / (2 * a);
            Console.WriteLine("Phương trình có nghiệm kép x1=x2=" + x1);

        } else {
            Console.WriteLine("Phương trình vô nghiệm");
        }
    }
}