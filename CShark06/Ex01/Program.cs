using Ex01;
using System.Collections;
using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<Book> books = new List<Book>()
        {
            new Book(){Id = "01",Author = "Aoyama Gōshō" ,Title = "Conan", Publisher = "Kim Dong", Year = 1994, Price = 10000},
            new Book(){Id = "02",Author = "Toriyama Akira" ,Title = "Dragon Ball", Publisher = "Kim Dong", Year = 1994, Price = 5000},
            new Book(){Id = "03",Author = "Aoyama Gōshō" ,Title = "Conan", Publisher = "Dai Nam", Year = 1994, Price = 6000},
            new Book(){Id = "04",Author = "Aoyama Gōshō" ,Title = "Conan1", Publisher = "Kim Dong", Year = 2014, Price = 10000},
            new Book(){Id = "05",Author = "Aoyama Gōshō" ,Title = "Conan2", Publisher = "Dai Nam", Year = 1994, Price = 6000},
            new Book(){Id = "06",Author = "Aoyama Gōshō" ,Title = "Conan3", Publisher = "Dai Bac", Year = 1994, Price = 10000},
            new Book(){Id = "07",Author = "Aoyama Gōshō" ,Title = "Conan4", Publisher = "Kim Dong", Year = 1994, Price = 2000},
            new Book(){Id = "08",Author = "Aoyama Gōshō" ,Title = "Conan5", Publisher = "Dai Bac", Year = 2014, Price = 10000},
            new Book(){Id = "09",Author = "Aoyama Gōshō" ,Title = "Conan6", Publisher = "Dai Nam", Year = 1994, Price = 1000},
            new Book(){Id = "10",Author = "Aoyama Gōshō" ,Title = "Conan7", Publisher = "Dai Bac", Year = 1994, Price = 6000},
        };

        Console.WriteLine("List Books:");
        foreach(var book in books)
        {
            Console.WriteLine(book);
        }

        //giá tăng dần
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List Books tang dan:");
        List<Book> sortByPrice = books.OrderBy(book => book.Price).ToList();
        foreach (var book in sortByPrice)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Nhap title can tim: ");
        string find = Console.ReadLine();

        //C1:
        //foreach (var book in books)
        //{
        //    if(String.Compare(find, book.Title, true) == 0)
        //    {
        //        Console.WriteLine(book);
        //    }
        //}
        //C2:
        Book bookfound = books.Find(book => String.Compare(find, book.Title, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase) == 0);
        if(bookfound != null)
        {
            Console.WriteLine("Đã thấy sách");
            Console.WriteLine(bookfound);
        }
        else
        {
            Console.WriteLine("Ko tìm thấy");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("book xuat ban nam 2014 la: ");
        foreach (var book in books)
        {
            if (book.Year == 2014)
            {
                Console.WriteLine(book);
            }
        }

        //xoa sach Kim dong

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Nhap nha xuat ban muốn xóa");
        string remove = Console.ReadLine();
        int bookRemove = books.RemoveAll(book => String.Compare(book.Publisher, remove, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase ) == 0);
        Console.WriteLine($"Đã xóa {bookRemove} quyen sách của nhà xuất bản {remove}");
        Console.WriteLine("List Books sau xoa:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}