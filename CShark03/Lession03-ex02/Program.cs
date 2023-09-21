using Lession03_ex02;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Book book = new Book("Dạy cách chiến đấu", 3, "11", "Cách đấm chết mấy thằng Muay Thái");

        book.Display();
        book.flipPageForWar();
        book.flipPageBackWar();
        book.flipPageBackWar();
        book.flipPageBackWar();


    }
}