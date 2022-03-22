using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Cat:Animal
    {
        public Cat(string name, string area, int len, int height)
        {
            this.name = name;
            this.habitatarea = area;
            this.weight = len;
            this.height = height;
            this.sound = "mew mew";
        }
    }
}
