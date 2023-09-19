using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int sum = 0;
        for (int i = 2; i < 101; i++)
        {
            if(i%2==0 && i%3 != 0)
            {
                sum += i;
            }
        }
        Console.WriteLine("Tổng các số chẵn không chia hết cho 3 từ 1 đến 100 là: " + sum);
    }
}