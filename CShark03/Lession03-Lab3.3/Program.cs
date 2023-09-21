using Lession03_Lab3._3;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        StudentModal a = new StudentModal();

        List<Student> students = a.GetStudents();

        Console.WriteLine("Danh sách các sinh viên là: ");
        foreach(Student student in students)
        {
            student.Display();
        }

        Student s = a.GetStudents(2);
        Console.WriteLine("Sinh viên có mã sinh viên 2 là: ");
        s.Display();

        List<Student> studentsAge = a.GetStudents(18, 30);
        Console.WriteLine("Danh sách các sinh viên có tuổi từ 18 đến 30 là: ");
        foreach (Student student in studentsAge)
        {
            student.Display();
        }
    }
}