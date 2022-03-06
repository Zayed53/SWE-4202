using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class employee
    {
        public string Id;
        public string FName;
        public string Lname;
        public string email;
        public string phone;
        public string hiredate;
        public string jobid;
        public string salary;
        public string managerID;
        public string depertmentID;

        public employee(string id, string first, string lastm, string email, string phone, string date, string jobid, string salary, string managerID, string depertmentID)
        {
            this.Id = id;
            this.FName = first;
            this.Lname = lastm;
            this.email = email;
            this.phone = phone;
            this.hiredate = date;
            this.jobid = jobid;
            this.salary = salary;
            this.managerID = managerID;
            this.depertmentID = depertmentID;
        }
    }
}
