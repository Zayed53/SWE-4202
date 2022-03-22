using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1console
{
    internal class rectangle:two_dimensiona
    {
        int len;
        int wid;
        public override int area(int len, int wid)
        {
            return len * wid; 
        }
        public override int parameter(int len, int wid)
        {
            return len + wid;
        }
    }
}
