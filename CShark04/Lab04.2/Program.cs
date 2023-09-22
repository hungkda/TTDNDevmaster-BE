using Lab04._2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Student College");
        StudentCollege sv1 = new StudentCollege("Hang", 1999, 7, 5, 5);
        sv1.Display();
        Console.WriteLine("Average of score: {0}", sv1.Average());

        Console.WriteLine("Student University");
        StudentUniversity sv2 = new StudentUniversity("Ha", 1999, 7, 5, 5, 9);
        sv2.Display();
        Console.WriteLine("Average of score: {0}", sv2.Average());
    }
}