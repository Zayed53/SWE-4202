using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class CurrentBalance : Account
    {
        public static int charge = 100;
        public static string accountprefix = "100";

        public string nextaccount;

        public CurrentBalance(string name, float balance)
        {
            this.accountname = name;
            this.balance = balance;
            Random rand = new Random();
            string num= Convert.ToString(rand.Next());
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
