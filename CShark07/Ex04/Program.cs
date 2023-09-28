using Ex04;

internal class Program
{
    private static void Main(string[] args)
    {
        Lecture lecture = new Lecture();
        try
        {
            lecture.Nhap();
            if (lecture.Salary > 60.000M || lecture.Bonus < 10.000M)
            {
                throw new AmountException();
            }
        }
        catch (AmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (lecture.Salary > 60.000M && lecture.Bonus < 10.000M)
            {
                lecture.Display();
            }

        }
    }
}