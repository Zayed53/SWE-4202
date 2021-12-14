using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class medicine
    {
        private string medname;
        private int medprice;
        private int medquantity;
        //private int meddate;
        private int medcode;

        //account dummyaccount = new account();


        public medicine( string medname, int medprice, int medquantity, int medcode)
        {
            this.medname = medname;
            this.medprice = medprice;
            this.medquantity = medquantity;
            //this.meddate = meddate;
            this.medcode = medcode;

        }public string getmedname()
        {
            return medname;
        }
        public int getmedprice()
        {
            return medprice;
        }
        public int getmedquantity()
        {
            return medquantity;
        }public int getmedcode()
        {
            return medcode;
        }

        public void decrease(int num)
        {
            medquantity = medquantity - num;
        }
    }
}
