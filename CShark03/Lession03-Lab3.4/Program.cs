
using Lession03_Lab3._4;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //dùng ref giúp đổi vị trí cho nhau
        //out giúp trả về giá trị
        int a = 20, b = 30;
        double area;
        Utility u = new Utility();
        Console.WriteLine("Trước khi hoán vị a= {0}, b= {1}", a, b);
        u.SwapFake(a,b);
        Console.WriteLine("Sau khi hoán vị không dùng ref a= {0}, b= {1}", a, b);
        u.SwapReally(ref a,ref b);
        Console.WriteLine("Sau khi hoán vị dùng ref a= {0}, b= {1}", a, b);
        u.AreaCircle(a, out area);
        Console.WriteLine("Chi vi hình tròn là: " + area);
    }
}