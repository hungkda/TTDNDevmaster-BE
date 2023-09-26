using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06._3
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public double Avg {  get; set; }

        public override string ToString()
        {
            return "\nID: "+ Id + "\nName: " +Name + "\nGender: " +(Gender?"Male":"Female") + "\nAverage marks: " +Avg;
        }
    }
}
