using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._3
{
    abstract class Shape
    {
        protected float radius, width, length;

        public abstract float Area();
        public abstract float Circumference();

    }
}
