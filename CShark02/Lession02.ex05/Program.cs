internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 7; i++)
        {
            for(int j = 0; j< i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = 7; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("$");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 7; i++)
        {
            for (int j = i; j < 7; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            for (int j = i-1; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}