using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1console
{
    internal class Circle : two_dimensiona
    {
        double radius;
        double pi = 3.14;
        public override double area( double radius, double pi)
        {
            return radius*radius * pi;
        }
        public override double parameter(double radius, double pi)
        {
            return 2 * pi * radius;
        }
    }
}
