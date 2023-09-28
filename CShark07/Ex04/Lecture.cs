using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class AmountException : Exception
    {
        public AmountException() : base("Luong phai lon hon 60.000 $, Thuong phai nho hon 10.000 $") { }
    }
    internal class Lecture
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }

        public void Nhap()
        {

            Console.Write("Nhap Name: ");
            Name = Console.ReadLine();

            Console.Write("Nhap Salary: ");
            Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Nhap Bonus: ");
            Bonus = Convert.ToDecimal(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Bonus: " + Bonus);

        }
    }
}
