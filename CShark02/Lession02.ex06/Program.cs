using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double a, b, c;
        Console.Write("Nhập số thứ nhất: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        c = Convert.ToDouble(Console.ReadLine());
        if(a>0 && b>0 && c>0 && (a+b)>c && (b+c)>a && (c+a)>b)
        {
            if(Math.Abs(a) == Math.Abs(b) + Math.Abs(c) || Math.Abs(b) == Math.Abs(a) + Math.Abs(c) || Math.Abs(c) == Math.Abs(b) + Math.Abs(a))
            {
                Console.WriteLine("3 số đã nhập tạo thành 3 cạnh của tam giác vuông");
            }else if(Math.Abs(a) > Math.Abs(b) + Math.Abs(c) || Math.Abs(b) > Math.Abs(a) + Math.Abs(c) || Math.Abs(c) > Math.Abs(b) + Math.Abs(a))
            {
                Console.WriteLine("3 số đã nhập tạo thành 3 cạnh của tam giác tù");
            }else if(a == b && a == c)
            {
                Console.WriteLine("3 số đã nhập tạo thành 3 cạnh của tam giác đều");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("3 số đã nhập tạo thành 3 cạnh của tam giác cân");
            }
            else
            {
                Console.WriteLine("3 số đã nhập tạo thành 3 cạnh của tam giác nhọn");
            }
        }
        else
        {
            Console.WriteLine("3 số đã nhập không tạo thành 3 cạnh của tam giác");
        }
    }
}