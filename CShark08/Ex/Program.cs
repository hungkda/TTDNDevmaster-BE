using Ex;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>()
        {
            new Book(){Id = "01",Author = "Aoyama Gōshō" ,Name = "lap trinh C#", Publisher = "giao duc", Year = 1994, Price = 10000},
            new Book(){Id = "02",Author = "Toriyama Akira" ,Name = "Dragon Ball", Publisher = "Kim Dong", Year = 1994, Price = 5000},
            new Book(){Id = "03",Author = "Aoyama Gōshō" ,Name = "Conan", Publisher = "Dai Nam", Year = 1994, Price = 6000},
            new Book(){Id = "04",Author = "Aoyama Gōshō" ,Name = "Conan1", Publisher = "giao duc", Year = 2014, Price = 10000},
            new Book(){Id = "05",Author = "Aoyama Gōshō" ,Name = "Conan2", Publisher = "Dai Nam", Year = 1994, Price = 6000},
            new Book(){Id = "06",Author = "Aoyama Gōshō" ,Name = "lap trinh C++", Publisher = "Dai Bac", Year = 1994, Price = 10000},
            new Book(){Id = "07",Author = "Aoyama Gōshō" ,Name = "Conan4", Publisher = "giao duc", Year = 1994, Price = 2000},
            new Book(){Id = "08",Author = "Aoyama Gōshō" ,Name = "Conan5", Publisher = "Dai Bac", Year = 2015, Price = 10000},
            new Book(){Id = "09",Author = "Aoyama Gōshō" ,Name = "Conan6", Publisher = "Dai Nam", Year = 1994, Price = 1200},
            new Book(){Id = "10",Author = "Aoyama Gōshō" ,Name = "Conan7", Publisher = "giao duc", Year = 1994, Price = 6000},
        };

        Console.WriteLine("All Book:");
        foreach (var book in books)
        {
            Console.WriteLine("\nID: " + book.Id + " Name: " + book.Name + " Author: " + book.Author + " Publisher: "
    + book.Publisher + " Year: " + book.Year + " Price: " + book.Price);
        }

        //sách có giá từ 1000-5000
        var queryBook = books.Where(x => x.Price >= 1000 && x.Price <= 5000);
        Console.WriteLine("\n\n\nAll Book 1000 < x < 5000:");
        foreach (var book in queryBook)
        {
            Console.WriteLine("\nID: " + book.Id + " Name: " + book.Name + " Author: " + book.Author + " Publisher: "
    + book.Publisher + " Year: " + book.Year + " Price: " + book.Price);
        }

        //sách xuất bản từ 2015
        var queryYearBook = books.Where(x => x.Year >= 2015 );
        Console.WriteLine("\n\n\nAll Book have year >= 2015");
        foreach (var book in queryYearBook)
        {
            Console.WriteLine("\nID: " + book.Id + " Name: " + book.Name + " Author: " + book.Author + " Publisher: "
    + book.Publisher + " Year: " + book.Year + " Price: " + book.Price);
        }

        //sách có tên lập trình
        var queryNameBook = books.Where(x => x.Name.Contains("lap trinh"));
        Console.WriteLine("\n\n\nAll Book have name like lap trinh");
        foreach (var book in queryNameBook)
        {
            Console.WriteLine("\nID: " + book.Id + " Name: " + book.Name + " Author: " + book.Author + " Publisher: "
    + book.Publisher + " Year: " + book.Year + " Price: " + book.Price);
        }

        //đếm sách có nhà xuất bản giáo dục
        var count = books.Where(x => x.Publisher.Contains("giao duc")).Count();
        Console.WriteLine("\n\n\nCount Book have pulisher like giao duc: " + count);
    }
}