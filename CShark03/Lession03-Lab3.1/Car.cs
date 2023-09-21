using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession03_Lab3._1
{
    internal class Car
    {
        public string make;
        public string model;
        public string color;
        public int year;

        public void Start()
        {
            Console.WriteLine(model + " khoi dong");
        }

        public void Stop()
        {
            Console.WriteLine(model + " dừng");
        }
    }
}
