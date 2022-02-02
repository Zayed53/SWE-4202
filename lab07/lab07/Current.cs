using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal class Current : account
    {
        //public List<int> depositelist = new List<int>; 
        public Current( int balance)
        {
            this.account_balance = balance;
            Random no=new Random();
            this.acount_no = Convert.ToString(no.Next());
        }
        public override void deposite( int num)
        {
            account_balance += num;
            depositlist.Add("Deposite"+Convert.ToString(num)+"\t"+vardate);

        }
        public override void Withdraw(int num)
        {
            account_balance -= num;
            depositlist.Add("Withdraw" + Convert.ToString(num) + "\t" + vardate);
            if (account_balance < 0)
            {
                throw new Exception();
            }
        }public override void suffixadder()
        {
            acount_no = "300" + acount_no;
        }
    }
}
