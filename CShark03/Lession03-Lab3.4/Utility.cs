using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession03_Lab3._4
{
    internal class Utility
    {
        //ko dùng ref
        public void SwapFake(int a, int b)
        {
            int tg = a;
            a = b;
            b=tg;
        }

        //dùng ref
        public void SwapReally(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        //dùng out
        public void AreaCircle(double radius, out double area)
        {
            area = 2* Math.PI * radius;
        }
    }
}
