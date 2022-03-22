using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Account
    {
        protected string accountNo;
        protected string accountname;
        protected float balance;

        public string getaccountNo()
        {
            return accountNo;
        }
        public string getaccountname()
        {
            return accountname;
        }
        public float getbalanc()
        {
            return balance;
        }

    }
}
