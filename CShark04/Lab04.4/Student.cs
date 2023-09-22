using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._4
{
    internal class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Delete(object obj)
        {
            Console.WriteLine("Đã xóa đối tượng: " + obj);
        }

        public void Display(object obj)
        {
            Student student = obj as Student;
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
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
