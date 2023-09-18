
internal class Program
{
    private static void Main(string[] args)
    {
        //Kiểu dữ liệu
        //int, long, short, byte
        int number = 20000;
        Console.WriteLine(number);

        //Số thực: float, double, decimal;
        //float: kiểu số thực có độ chính xác kém nhất
        //double: kiểu số thực có độ chính xác cao
        //decimal: kiểu số thực có độ chính xác cao 
        double mark = 2.5;
        Console.WriteLine(mark);

        //Kiểu ký tự và chuỗi
        //char: kiểu dữ liệu Unicode, có kích thước 16-bit
        //string: kiểu chuỗi ký tự
        string name = Console.ReadLine();
        Console.WriteLine(name);

        //kiểu logic
        //bool: trả về True hoặc False
        bool check = false;
        Console.WriteLine(check);

        //kiểu ngày và thời gian
        //DateTime: ngày và thời gian
        //TimeSpan: 1 khoảng thời gian
        DateTime date = new DateTime(2023, 9, 18);
        Console.WriteLine(date);
        Console.WriteLine(date.ToString("dd-MM-yyyy"));

        //Dặt tên biến có phân biệt chữ hoa chữ thường
        string full = "dd";
        string Full = "aa";

        //Các toán tử
        //số học
        int a = 1;
        int b = 2;
        int c = a + b;
        Console.WriteLine(c);

        //So sánh
        bool d = a > b;
        Console.WriteLine(d);

        //logic
        int e = 2;
        bool f = a < b && b == e;
        Console.WriteLine(f);

        //gán
        int g = 3;
        g *= 4;
        Console.WriteLine(g);

        //Tăng giảm
        int h = 4;
        int i = 5;
        h++;
        i--;
        Console.WriteLine(h);
        Console.WriteLine(i);

        //Nối chuỗi
        string string1 = "Con gà";
        string string2 = "Gà con";
        string result = string1 + " " + string2;
        Console.WriteLine(result);

        //Điều kiện
        int k = 3;
        int m = 5;
        string numberResult = (k > m) ? "k lon hon m u ghe qua" : "k ga qua nho hon m";
        Console.WriteLine(numberResult);

        //aaaasa
        //    asa

    }
}