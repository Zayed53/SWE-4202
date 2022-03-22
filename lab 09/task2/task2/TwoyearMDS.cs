using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class TwoyearMDS : MonthlydepositeScheme
    {
        public int maximuminterest;

        public TwoyearMDS(string name,int interest, float balance, int rate, int deposite)
        {
            this.interestrate = interest;
            this.accountname = name;
            this.balance = balance;
            this.interestrate = rate;
            this.monthlydepositeamount = deposite;
            Random rand = new Random();
            string num = Convert.ToString(rand.Next());
            this.nextaccount = num;
            this.accountNo = accountprefix + num;
        }
    }
