using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1console
{
    internal abstract class Three_dimention: Shape
    {
        public abstract double volume(double x, double y, double z);

        public abstract double surfacearea(double x, double y, double z);
    }
}
