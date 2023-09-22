using Lab04._4;
using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        IPerson staff = new Staff();
        object data = "Đại học nguyễn trãi";

        staff.Insert(data);
        staff.Delete(data);
        staff.Update(data);
        staff.Display(data);

        IPerson student = new Student() {Id = 1, Name = "Gà", Age = 18 };

        student.Display(student);
    }
}