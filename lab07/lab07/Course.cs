using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal class Course
    {
        public string coursetittle;
        public string courselevel;
        public int coursefee;

        public Course(string coursetittle, int cousefee)
        {
            this.coursetittle = coursetittle;
            this.courselevel ="Beginner";
            this.coursefee = cousefee;
        }
    }
}
