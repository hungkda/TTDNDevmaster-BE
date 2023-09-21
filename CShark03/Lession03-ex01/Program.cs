using Lession03_ex01;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int salary;
        Console.WriteLine("Nhập lương cơ bản");
        salary = Convert.ToInt32(Console.ReadLine());
        Employee employee = new Employee(1, "Gà", 1999, salary, 2);
        Employee employee1 = new Employee(2, "Mèo", 1119, salary, 3);
        Employee employee2 = new Employee(3, "Lợn", 1000, salary, 4);
        employee.Display();
        employee1.Display();
        employee2.Display();

    }
}