using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // hiển thị có dấu
        Console.OutputEncoding = Encoding.UTF8;
        string MNV = "NV01";
        string name = "Gorden Jamsay";
        DateOnly dateOfBirth = new DateOnly(2023, 12 , 1);
        string address = "The largest slum in Vietnam";
        string phoneNumber = "1234567890";
        string email = "gordenJamsayMC@gamcau.com";
        //display
        Console.WriteLine("Mã nhân viên: " + MNV);
        Console.WriteLine("Tên nhân viên: " + name);
        Console.WriteLine("Ngày sinh: " + dateOfBirth.ToString("dd-MM-yyyy"));
        Console.WriteLine("Địa chỉ: " + address);
        Console.WriteLine("SDT: " + phoneNumber);
        Console.WriteLine("email: " + email);
    }
}