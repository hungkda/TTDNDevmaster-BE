using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //COnvert
        string a = "17";
        string b = "16";
        int c = Convert.ToInt32((string)a);
        int d = Convert.ToInt32((string)b);

        Console.WriteLine(c + d);

        // if else
        Console.WriteLine("Nhập giá trị a");
        int e = Convert.ToInt32(Console.ReadLine());
        if (e % 2 == 0)
        {
            Console.WriteLine("e là số chẵn");
        }
        else
            Console.WriteLine("e là số lẻ");

        // switch case
        Console.WriteLine("Nhập giá trị d");
        int h = Convert.ToInt32(Console.ReadLine());
        switch (h)
        {
            case 0: 
                Console.WriteLine("h =0");
                break;
            case 1:
                Console.WriteLine("h =1");
                break;
            case 2:
                Console.WriteLine("h=2");
                break;
            default:
                Console.WriteLine("h khác 0 1 2");
                break;
        }

    }
}