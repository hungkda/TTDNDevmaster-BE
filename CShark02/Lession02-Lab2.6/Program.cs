using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string[] name = { "gà", "mèo", "lợn", "chó" };
        foreach (string s in name)
        {
            Console.WriteLine(s);
        }
    }
}