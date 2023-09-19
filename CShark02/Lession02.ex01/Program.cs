using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string id, name, address;
        double salary, bonus, totalSalary;
        DateTime dateOfBirth;
        //nhập
        Console.Write("Nhập mã nhân viên: ");
        id = Console.ReadLine();
        Console.Write("Nhập tên nhân viên: ");
        name = Console.ReadLine();
        Console.Write("Nhập địa chỉ: ");
        address = Console.ReadLine();
        Console.Write("Nhập ngày sinh: ");
        dateOfBirth = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Nhập tiền lương: ");
        salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập tiền thưởng: ");
        bonus = Convert.ToInt32(Console.ReadLine());
        totalSalary = salary + bonus;
        // display
        Console.WriteLine("*******THÔNG TIN NHÂn VIÊN*******");
        Console.WriteLine("Mã nhân viên: " + id);
        Console.WriteLine("tên nhân viên: " + name);
        Console.WriteLine("Địa chỉ: " + address);
        Console.WriteLine("ngày sinh: " + dateOfBirth.ToString("dd-MM-yyyy"));
        Console.WriteLine("Tiền lương: ", salary);
        Console.WriteLine("Tiền thưởng: " + bonus);
        Console.WriteLine("Tổng Tiền lương: " + totalSalary);


    }
}