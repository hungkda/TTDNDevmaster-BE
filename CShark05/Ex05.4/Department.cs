using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05._4
{
    internal class Department
    {
        private string Name {  get; set; }
        private Employee[] Employees { get; set; }

        public Department() { }
        public Department(string name, int i) 
        {
            Employees = new Employee[i]; 
            Name = name; 
        }

        public Employee this[int index]
        {
            get { return Employees[index]; }
            set { Employees[index] = value; }
        }
    }
}
