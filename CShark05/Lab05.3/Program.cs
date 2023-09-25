using Lab05._3;

internal class Program
{
    private static void Main(string[] args)
    {
        Student st = new Student(3,2);
        st[0] = "ga";
        st[0, 0] = 1;
        st[0, 1] = 1;
        st[1] = "ga";
        st[1, 0] = 11;
        st[1, 1] = 12;
        st[2] = "meo";
        st[2, 0] = 1;
        st[2, 1] = 1;
        Console.WriteLine("Thoong tin sinh vien");
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ten: " + st[i]);
            Console.Write("Diem: ");
            for(int j = 0; j < 2; j++)
            {
                Console.Write(st[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}