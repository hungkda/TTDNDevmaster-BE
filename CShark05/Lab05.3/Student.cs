using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05._3
{
    internal class Student
    {
        private string[] names;
        private double[,] marks;

        public Student(int i, int j)
        {
            this.names = new string[i];
            this.marks = new double[i, j];
        }

        //chi mucj don
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }

        // kep
        public double this[int i, int j]
        {
            get { return marks[i, j]; }
            set { marks[i, j] = value; }
        }
    }
}
