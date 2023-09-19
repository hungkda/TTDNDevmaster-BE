using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string name;
        int num;
        double money;
        //nhập
        Console.Write("Nhập tên thuê bao: ");
        name = Console.ReadLine();
        Console.Write("Nhập số điện sử dụng: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 50)
        {
            money = 30 + 20 * 1.2 + (num - 50) * 1.5;
        }
        else if (num > 30)
        {
            money = 30 + (num - 30) * 1.2;
        }
        else
            money = 30;
        // display
        Console.WriteLine("tên thuê bao: " + name);
        Console.WriteLine("Số điện trên công tơ là: " + num);
        Console.WriteLine("Tiền điện là: {0}$", money);

    }
}