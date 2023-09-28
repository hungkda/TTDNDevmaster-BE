internal class Program
{
    private static void Main(string[] args)
    {
        string[] data = new string[5];

        try
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("data[{0}]= ", i + 1);
                data[i] = Console.ReadLine();
            }
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArrayTypeMismatchException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(data[i]);
        }
    }
}