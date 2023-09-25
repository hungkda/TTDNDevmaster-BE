using Ex05._4;

internal class Program
{
    private static void Main(string[] args)
    {
        Department department = new Department("IT", 3);

        department[0] = new Employee(1, "Chicken", 18);
        department[1] = new Employee(2, "Dog", 19);
        department[2] = new Employee(3, "Duck", 1);

        Console.WriteLine("Employees details: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Employss " + (i + 1));
            department[i].Display();
            Console.WriteLine();
        }
    }
}