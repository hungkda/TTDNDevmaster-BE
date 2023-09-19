using System.Net;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Các số nguyên tố từ 2 đến 100 là: ");
        for (int i = 2;  i < 101; i++)
        {
            bool check = true;
            for(int j = 2;  j <= i/2; j++)
            {
                if (i % j == 0)
                {
                    check = false;
                }
            }
            if ( check )
            {
                Console.Write(i + " ");
            }
        }
    }
}