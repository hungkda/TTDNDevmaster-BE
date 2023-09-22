using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._4
{
    internal class Staff : IPerson
    {

        public void Delete(object obj)
        {
            Console.WriteLine("Đã xóa đối tượng: " + obj);
        }

        public void Display(object obj)
        {
            Console.WriteLine("Thôn tin đối tượng: " + obj);
        }

        public void Insert(object obj)
        {
            Console.WriteLine("Đã lưu đối tượng: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Đã cập nhật đối tượng: " + obj);
        }
    }
}
