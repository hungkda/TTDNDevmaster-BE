using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession03_ex02
{
    internal class Book
    {
        public string author { get; set; }
        public int pages { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentpage { get; set; }

        public Book() 
        {
            currentpage = 1;
        }

        public Book(string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentpage = 1;
        }

        public void flipPageForWar()
        {
            if (currentpage == 1)
            {
                Console.WriteLine("Đang trang 1 thì sao lật về trang trước");
            } else
            {
                currentpage--;
                Console.WriteLine("Bạn đang trang: " + currentpage);
            }
        }

        public void flipPageBackWar()
        {
            if (currentpage == pages)
            {
                Console.WriteLine("Bạn đã đọc xong");
            }
            else
            {
                currentpage++;
                Console.WriteLine("Bạn đang trang: " + currentpage);
            }
        }

        public void Display()
        {
            Console.WriteLine("Tác giả: " + author);
            Console.WriteLine("Số trang: " + pages);
            Console.WriteLine("Mã số tiêu chuẩn quốc tế: " + isbn);
            Console.WriteLine("Tiêu đề: " + title);
        }
    }
}
