using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1console
{
    internal class triangle:two_dimensiona
    {
        int bas;
        int height;
        
        public override double area(double bas, double height)
        {
            return 0.5*bas*height;
        }
        public override double parameter(double bas, double height)
        {
            return 0.5*(bas+height);
        }
    }
}
