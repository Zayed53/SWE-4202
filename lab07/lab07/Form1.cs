using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bank dummybank = new Bank();
        private void Create_Click(object sender, EventArgs e)
        {
            if (account_typecombo.Text == "Current")
            {
                Current democurrent = new Current(Convert.ToInt32(depositebox.Text));
                democurrent.suffixadder();
                dummybank.currentlist.Add(democurrent);

            }else if (account_typecombo.Text == "Savings")
            {
                Savings demosaving = new Savings(Convert.ToInt32(depositebox.Text));
                demosaving.suffixadder();
                dummybank.savinglist.Add(demosaving);

            }
            else if (account_typecombo.Text == "Loan")
            {
                Loan demoloan = new Loan(Convert.ToInt32(depositebox.Text));
                demoloan.suffixadder();
                dummybank.loanlist.Add(demoloan);

            }
            MessageBox.Show("account created");

        }

        private void infrmacctypecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (account_typecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                    infrmaccountidcombo.Items.Add(crnt.acount_no);
            }
            else if (account_typecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                    infrmaccountidcombo.Items.Add(crnt.acount_no);
            }
            else if (account_typecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                    infrmaccountidcombo.Items.Add(crnt.acount_no);
            }
        }

        private void showinformation_Click(object sender, EventArgs e)
        {
            string check = infrmaccountidcombo.Text;
            if (account_typecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                {
                    if(crnt.acount_no == check)
                    {
                        listBox1.Items.Add("Current\t" + "accountn:" + crnt.acount_no + "account balance:" + Convert.ToString(crnt.account_balance));
                    }
                }
            }
            else if (account_typecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                {
                    if (crnt.acount_no == check)
                    {
                        listBox1.Items.Add("Saving\t" + "accountn:" + crnt.acount_no + "account balance:" + Convert.ToString(crnt.account_balance));
                    }
                }
            }
            else if (account_typecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                {
                    if (crnt.acount_no == check)
                    {
                        listBox1.Items.Add("Loan\t" + "accountn:" + crnt.acount_no + "account balance:" + Convert.ToString(crnt.account_balance));
                    }
                }
            }
        }

        private void depositetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (depositetypecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                    depositeaccountcombo.Items.Add(crnt.acount_no);
            }
            else if (depositetypecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                    depositeaccountcombo.Items.Add(crnt.acount_no);
            }
            else if (depositetypecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                    depositeaccountcombo.Items.Add(crnt.acount_no);
            }
        }

    
       

        private void Withdrawtypecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Withdrawtypecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                    Withdrawaccountcombo.Items.Add(crnt.acount_no);
            }
            else if (Withdrawtypecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                    Withdrawaccountcombo.Items.Add(crnt.acount_no);
            }
            else if (Withdrawtypecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                    Withdrawaccountcombo.Items.Add(crnt.acount_no);
            }

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            string check = Withdrawaccountcombo.Text;
            if (Withdrawtypecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                {
                    if (crnt.acount_no == check)
                    {
                        try
                        {
                            crnt.vardate = dateTimePicker2.Value.ToShortDateString();
                            crnt.Withdraw(Convert.ToInt32(withdrawamntbox.Text));
                        }catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if (Withdrawtypecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                {
                    if (Convert.ToInt32(lastwithbx.Text) < 5)
                    {
                        Exception ex = new Exception();
                        MessageBox.Show(ex.Message);
                    }
                    if (crnt.acount_no == check)
                    {
                        crnt.vardate = dateTimePicker2.Value.ToShortDateString();
                        crnt.Withdraw(Convert.ToInt32(withdrawamntbox.Text));
                    }
                }
            }
            else if (Withdrawtypecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                {
                    if (crnt.acount_no == check)
                    {
                        crnt.vardate = dateTimePicker2.Value.ToShortDateString();
                        crnt.Withdraw(Convert.ToInt32(withdrawamntbox.Text));
                    }
                }
            }MessageBox.Show("Withdrawn");

        }

        private void Deposite_Click(object sender, EventArgs e)
        {
            string check = depositeaccountcombo.Text;
            if (depositetypecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                {
                    if (crnt.acount_no == check)
                    {
                        crnt.vardate = dateTimePicker1.Value.ToShortDateString();
                        crnt.deposite(Convert.ToInt32(newdeposite.Text));
                    }
                }
            }
            else if (depositetypecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                {
                    if (crnt.acount_no == check)
                    {
                        crnt.vardate = dateTimePicker1.Value.ToShortDateString();
                        crnt.deposite(Convert.ToInt32(newdeposite.Text));
                    }
                }
            }
            else if (depositetypecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                {
                    if (crnt.acount_no == check)
                    {
                        crnt.vardate = dateTimePicker1.Value.ToShortDateString();
                        crnt.deposite(Convert.ToInt32(newdeposite.Text));
                    }
                }
            }
            MessageBox.Show("Deposite");
        }

        private void historytypecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (historytypecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                    historynocombo.Items.Add(crnt.acount_no);
            }
            else if (historytypecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                    historynocombo.Items.Add(crnt.acount_no);
            }
            else if (historytypecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                    historynocombo.Items.Add(crnt.acount_no);
            }

        }

        private void History_Click(object sender, EventArgs e)
        {
            string check = historynocombo.Text;
            if (historytypecombo.Text == "Current")
            {
                foreach (Current crnt in dummybank.currentlist)
                {
                    if (crnt.acount_no == check)
                    {
                        foreach(String id in crnt.depositlist)
                        {
                            historylist.Items.Add(id);
                        }
                    }
                }
            }
            else if (historytypecombo.Text == "Savings")
            {
                foreach (Savings crnt in dummybank.savinglist)
                {
                    if (crnt.acount_no == check)
                    {
                        foreach (String id in crnt.depositlist)
                        {
                            historylist.Items.Add(id);
                        }
                    }
                }
            }
            else if (historytypecombo.Text == "Loan")
            {
                foreach (Loan crnt in dummybank.loanlist)
                {
                    if (crnt.acount_no == check)
                    {
                        foreach (String id in crnt.depositlist)
                        {
                            historylist.Items.Add(id);
                        }
                    }
                }
            }
        }
    }
}
