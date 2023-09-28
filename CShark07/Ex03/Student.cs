using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TheoryMark { get; set; }
        public double labMark { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap Name: ");
            Name = Console.ReadLine();

            Console.Write("Nhap TheoryMark: ");
            TheoryMark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap labMark: ");
            labMark = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("TheoryMark: " + TheoryMark);
            Console.WriteLine("labMark: " + labMark);

        }
    }

    internal class InvalidMarkException : Exception
    {
        public InvalidMarkException() : base("Diem phai trong khoang 0-10") { }
    }
}
