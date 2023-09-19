using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        char a;
        Console.WriteLine("Nhập kí tự: ");
        a = Convert.ToChar(Console.ReadLine());
        switch (a)
        {
            case 'a':
            case 'e':
            case 'u':
            case 'o':
                Console.WriteLine("Đây là nguyên âm");
                break;
            default:
                Console.WriteLine("Đây là phụ âm");
                break;
        }
    }
}