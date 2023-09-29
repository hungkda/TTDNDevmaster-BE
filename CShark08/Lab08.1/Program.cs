internal class Program
{
    private static void Main(string[] args)
    {
        string[] data = {"To", "ve", "hon", "nguoi", "thi", "nguoi", "se", "tro", "thanh",
        "ke", "thu", "cua", "ta", "chiu", "nhuong", "nguoi", "thi", "nguoi", "se", "la", "ban", "cua", "ta"};

        //truy vấn dữ liệu
        IEnumerable<string> result1 = from m in data select m;

        Console.WriteLine("Hien thi tat ca ket qua: ");
        foreach (string s in result1) Console.Write(s + " ");
        Console.WriteLine();
        //truy van dieu kien lay tu nguoi
        IEnumerable<string> result2 = from m in data where m.Equals("nguoi") select m;
        Console.WriteLine("\nTruy van theo dieu kien: ");
        foreach (string s in result2) Console.Write(s + " ");
        Console.WriteLine();
        //sap xep
        IEnumerable<string> result3 = from m in data orderby m select m;
        Console.WriteLine("\nHien thi ket qua da sap xep: ");
        foreach (string s in result3) Console.Write(s + " ");
        //lay tap du lieu moi
        var result4 = from m in data select new {Thuong = m.ToLower(), Hoa = m.ToUpper()};
        Console.WriteLine("\nChu thuonng va hoa: ");
        foreach (var s in result4) Console.WriteLine(s.Thuong + " : " + s.Hoa);
    }
}