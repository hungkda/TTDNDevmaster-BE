using Lab08._3;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //khai báo
        int[] Number = { 1, 2, 3, 4, 5, 6, 7, 8, 0, 3, 2, 1, 9, 2 };
        string[] String =
        {
            "Cái", "gọi", "là", "chính", "cùng", "tà", "cũng", "không", "hề", "có", "sự", "khác", "biệt", "chỉ", "là", "ta", "đẹp", "trai"
        };
        List<Film> films = new List<Film>()
        {
            new Film {FilmId = "F01", FilmName = "Trọng sinh ta max cấp lúc nào không hay", Price= 120000},
            new Film {FilmId = "F02", FilmName = "Ta siêu cấp đại phản phái", Price= 430000},
            new Film {FilmId = "F03", FilmName = "Trồng rau tại tu tiên giới", Price= 140000},
            new Film {FilmId = "F04", FilmName = "Ta là siêu cấp trạch nam", Price= 350000},
            new Film {FilmId = "F05", FilmName = "Hệ thống ta quá chi là bá đạo", Price= 160000},
            new Film {FilmId = "F06", FilmName = "Trọng sinh chi Avenger", Price= 170000},
            new Film {FilmId = "F07", FilmName = "GOA GOA NO MI ta làm hải tặc", Price= 220000},
        };

        //Lọc các số chẵn (Number)
        IEnumerable<int> queryNumber = Number.Where(x => x%2 == 0);
        Console.WriteLine("\nLọc các số chẵn: ");
        foreach(var e in queryNumber)
        {
            Console.Write("\t" + e + " ");
        }

        //Lọc các ký tự có độ dài > 4 (String)
        IEnumerable<string> queryString = String.Where(w => w.Length > 4);
        Console.WriteLine("\nLọc các ký tự có độ dài > 4: ");
        foreach (var e in queryString)
        {
            Console.Write("\t" + e + " ");
        }

        //Lọc các ký tự bắt đầu bằng chữ t (String)
        IEnumerable<string> queryT = String.Where(w => w.StartsWith("t"));
        Console.WriteLine("\nLọc các ký tự bắt đầu bằng chữ t: ");
        foreach (var e in queryT)
        {
            Console.Write("\t" + e + " ");
        }

        //Lọc các số duy nhất trong tập hợp số: (Number)
        IEnumerable<int> uniqueNumber = Number.Distinct();
        Console.WriteLine("\nLọc các số duy nhất trong tập hợp số: ");
        foreach (var e in uniqueNumber)
        {
            Console.Write("\t" + e + " ");
        }

        //Đếm xem có bao nhiêu từ không trùng nhau (String)
        var countDistinctString = String.Distinct().Count();
        Console.WriteLine("\nĐếm xem có bao từ không trùng nhau: " + countDistinctString);

        //Lấy 4 số đầu tiên trong dãy (Number)
        var fourNumber = Number.Take(4);
        Console.WriteLine("\nLấy 4 số đầu tiên trong dãy: ");
        foreach (var e in fourNumber)
        {
            Console.Write("\t" + e + " ");
        }

        //Lấy những từ có chứa chữ t (String)
        var searchString = String.Where(w => w.Contains("t"));
        Console.WriteLine("\nLấy những từ có chứa chữ t: ");
        foreach (var e in searchString)
        {
            Console.Write("\t" + e + " ");
        }

        //sắp xếp theo đơn giá. lấy những phim có đơn giá < 2000000 (films)
        var queryFilm = films.OrderBy(f => f.Price).Select(x => new {x.FilmId, x.FilmName, x.Price}).ToList().TakeWhile(t => t.Price < 200000);
        Console.WriteLine("\nSắp xếp theo đơn giá. lấy những phim có đơn giá < 2000000: ");
        foreach (var e in queryFilm)
        {
            Console.WriteLine("\t" + e);
        }

        //bỏ qua 3 phim đầu lấy các phim còn lại
        var skipFilm = films.Skip(3);
        Console.WriteLine("\nbỏ qua 3 phim đầu lấy các phim còn lại: ");
        foreach (var e in skipFilm)
        {
            Console.WriteLine("\t" + e);
        }

        //bỏ 3 phim đầu lấy 3 phim tiếp
        var skipTakeFilm = films.Skip(3).Take(3);
        Console.WriteLine("\nbỏ 3 phim đầu lấy 3 phim tiếp: ");
        foreach (var e in skipTakeFilm)
        {
            Console.WriteLine("\t" + e);
        }

        //Sắp xếp giảm dần sau đố lấy phần từ < 5
        var sortNumber = Number.OrderByDescending(x => x).SkipWhile(x => x > 5);
        Console.WriteLine("\nSắp xếp giảm dần sau đố lấy phần từ < 5: ");
        foreach (var e in sortNumber)
        {
            Console.WriteLine("\t" + e);
        }
    }
}