using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string id, name;
        double mark1, mark2, mark3, average;
        DateTime dateOfBirth;
        //nhập
        Console.Write("Nhập mã sinh viên: ");
        id = Console.ReadLine();
        Console.Write("Nhập tên sinh viên: ");
        name = Console.ReadLine();
        Console.Write("Nhập ngày sinh: ");
        dateOfBirth = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Nhập điểm môn 1: ");
        mark1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập điểm môn 2: ");
        mark2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập điểm môn 3: ");
        mark3 = Convert.ToInt32(Console.ReadLine());

        average = Math.Round((mark1 + mark2 + mark3) / 3, 2);
        // display
        Console.WriteLine("Mã sinh viên: " + id);
        Console.WriteLine("tên sinh viên: " + name);
        Console.WriteLine("ngày sinh: " + dateOfBirth.ToString("dd-MM-yyyy"));
        Console.WriteLine("Điểm các môn lần lượt là {0}, {1}, {2}", mark1, mark2, mark3);
        Console.WriteLine("Điểm trung bình: " + average);

    }
}