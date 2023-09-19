using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int tram, chuc, donvi;
        Console.WriteLine("các số chẵn có tổng 3 chữ số là số chẵn là: ");
        for (int i = 100; i < 1000; i++)
        {
            tram = i/100;
            chuc = (i-tram*100)/10;
            donvi = i%10;
            if((tram+chuc+donvi)%2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        
    }
}