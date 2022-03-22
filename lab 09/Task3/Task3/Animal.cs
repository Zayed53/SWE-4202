using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Animal
    {
        protected string name;
        protected string habitatarea;
        protected string sound;
        protected int weight;
        protected int height;

         
        public string setname()
        {
            return this.name;
        }
        public string getarea()
        {
            return (this.habitatarea);
        }
        //public abstract void setsound();

        public string getsound()
        {
            return sound;
        }
        public int getwid()
        {
            return weight;
        }
       
        public int getheight()
        {
            return height;
        }
        public string getinfo()
        {
            return(name+habitatarea+sound+Convert.ToString(this.weight));
        }
        public void changeweight(int w)
        {
            this.weight = weight + w;
        }

        
    }
}
