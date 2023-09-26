using Lab06._1;
using System.Collections;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList inv = new ArrayList();

        inv.Add(new Product("A", 5.4, 2));
        inv.Add(new Product("B", 5.4, 2));
        inv.Add(new Product("C", 5.4, 2));
        inv.Add(new Product("D", 5.4, 2));

        Console.WriteLine("List:");
        foreach (Product p in inv) Console.WriteLine(p);
    }
}