using Lab06._3;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(){Id = "01", Name = "Chicken", Gender = true, Avg = 9.9},
            new Student(){Id = "02", Name = "Dog", Gender = false, Avg = 1},
            new Student(){Id = "03", Name = "Cat", Gender = true, Avg = 2},
            new Student(){Id = "04", Name = "Shark", Gender = false, Avg = 4.4},
            new Student(){Id = "04", Name = "Whale", Gender = true, Avg = 10},
            new Student(){Id = "05", Name = "Kraken", Gender = false, Avg = 9.9},
            new Student(){Id = "06", Name = "Possiden", Gender = true, Avg = 0},
            new Student(){Id = "07", Name = "Hades", Gender = true, Avg = 0},

        };

        Console.WriteLine("List: ");
        foreach(Student student in students)
        {
            Console.WriteLine(student);
        }

        double max = students[0].Avg;
        Student stMax = students[0];

        Console.WriteLine("List: ");
        foreach (Student student in students)
        {
            if(student.Avg > max)
            {
                max = student.Avg;
                stMax = student;
            }
        }

        Console.WriteLine("Student with max mark: ");
        Console.WriteLine(stMax);
    }
}