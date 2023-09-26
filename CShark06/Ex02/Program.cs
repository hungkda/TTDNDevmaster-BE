internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<int, string> dayOfWeek = new SortedList<int, string>();
        dayOfWeek.Add(1, "Monday");
        dayOfWeek.Add(2, "Tuesday");
        dayOfWeek.Add(3, "Wednesday");
        dayOfWeek.Add(4, "Thursday");
        dayOfWeek.Add(5, "Friday");
        dayOfWeek.Add(6, "Saturday");
        dayOfWeek.Add(7, "Sunday");

        if (dayOfWeek.ContainsValue("Tuesday")) {
            Console.WriteLine("Tim dc Tuesday");
        }
        else
        {
            Console.WriteLine("Tim ko dc Tuesday");
        }

        foreach(int i in dayOfWeek.Keys)
        {
            Console.WriteLine(i + ": " + dayOfWeek[i]);
        }
    }
}