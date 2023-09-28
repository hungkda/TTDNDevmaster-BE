


using static Lab07._4.Cus;

internal class Program
{
    private static void Main(string[] args)
    {
        int intCnt;
        int intNum = 0;

        Console.WriteLine("Hay nhap 1 so: ");

        try
        {
            intNum = Convert.ToInt32(Console.ReadLine());
            if(intNum <= 0)
            {
                throw new InvalidInputNumber();
            }
        }
        catch (InvalidInputNumber e)
        {
            Console.WriteLine(e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if(intNum > 0) {
                for( intCnt = 0; intCnt < 10; intCnt++ )
                {
                    Console.WriteLine(intNum * intCnt);
                }
            }
        }

        Console.ReadLine();
    }
}