using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int year, month;
        Console.Write("Nhập năm: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập tháng: ");
        month = Convert.ToInt32(Console.ReadLine());
        while(month < 0 && month > 12) {
            Console.Write("Nhập lại tháng: ");
            month = Convert.ToInt32(Console.ReadLine());
        }
        switch (month) {
            case 1:
                Console.WriteLine("Tháng {0} năm {1} có 31 ngày", month, year);
                break;
            case 2:
                if (year % 4 == 0)
                {
                    Console.WriteLine("Tháng {0} năm {1} có 29 ngày", month, year);
                    break;
                }
                else
                {
                    Console.WriteLine("Tháng {0} năm {1} có 28 ngày", month, year);
                    break;
                }
            case 3:
                Console.WriteLine("Tháng {0} năm {1} có 31 ngày", month, year);
                break;
            case 4:
                Console.WriteLine("Tháng {0} năm {1} có 30 ngày", month, year);
                break;
            case 5:
                Console.WriteLine("Tháng {0} năm {1} có 31 ngày", month, year);
                break;
            case 6:
                Console.WriteLine("Tháng {0} năm {1} có 30 ngày", month, year);
                break;
            case 7:
                Console.WriteLine("Tháng {0} năm {1} có 31 ngày", month, year);
                break;
            case 8:
                Console.WriteLine("Tháng {0} năm {1} có 31 ngày", month, year);
                break;
            case 9:
                Console.WriteLine("Tháng {0} năm {1} có 30 ngày", month, year);
                break;
            case 10:
                Console.WriteLine("Tháng {0} năm {1} có 31 ngày", month, year);
                break;
            case 11:
                Console.WriteLine("Tháng {0} năm {1} có 30 ngày", month, year);
                break;
            default:
                Console.WriteLine("Tháng {0} năm {1} có 31 ngày", month, year);
                break;
        }
    }
}