using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class LoanAccount : Account
    {
        public int interestrate;
        public int monthlydepositeamount;
        public static string accountprefix = "900";


        public string nextaccount;

        public LoanAccount(string name, float balance, int rate, int deposite)
        {
            this.accountname = name;
            this.balance = balance;
            this.interestrate = rate;
            this.monthlydepositeamount = deposite;
            Random rand = new Random();
            string num = Convert.ToString(rand.Next());
            this.nextaccount = num;
            this.accountNo = accountprefix + num;
        }
        public void nextaccountno()
        {
            Random rand = new Random();
            string num = Convert.ToString(rand.Next());
            this.nextaccount = num;
        }
    }
}
