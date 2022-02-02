using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal abstract class account
    {
        public string acount_no;
        public int account_balance;

        public string vardate;

        public List<string> depositlist = new List<string>();
        //public string account_type;
        public abstract void deposite(int num);

        public abstract void Withdraw(int num);

        public abstract void suffixadder();
    }
}
