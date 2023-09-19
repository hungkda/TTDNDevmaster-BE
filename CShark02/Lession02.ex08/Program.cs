using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double soDu, tienGoc, laiSuat;
        int month;
        Console.Write("Nhập số tiền gửi: ");
        tienGoc = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số tháng gửi: ");
        month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập lãi suất theo năm: ");
        laiSuat = Convert.ToDouble(Console.ReadLine());

        soDu = tienGoc;

        for (int i = 1; i < month; i++)
        {
            soDu += soDu * (laiSuat / 12) / 100;
        }
        Console.WriteLine("Số dư cuối kì là: "+ soDu);
        Console.WriteLine("Tiền lãi cuối kì là: " + (soDu - tienGoc));
    }
}