using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class account
    {
        public static int account_balance;
        //public void setaccount_balance(int balance)
        //{
         //   this.account_balance = balance;
        //}
        public void increasebalance(int sale)
        {
            account_balance += sale;
            //return account_balance;
        }
        public void decreasebalance(int add)
        {
            account_balance -= add;
            //return account_balance;
        }
        //public int getaccountbalance()
        //{
        //    return account_balance;
        //}
    }
}
