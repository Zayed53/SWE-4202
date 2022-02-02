using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal class Bank
    {
        public List<Current> currentlist = new List<Current>();
        public List<Savings> savinglist = new List<Savings>();
        public List<Loan> loanlist = new List<Loan>();
    }
}
