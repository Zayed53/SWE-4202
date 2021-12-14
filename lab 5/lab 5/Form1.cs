using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        List<medicine> medicineList = new List<medicine>();
        public Form1()
        {
            InitializeComponent();
        }
        private void addaccount_Click(object sender, EventArgs e)
        {
            //account dummyaccount = new account();
            account.account_balance=Convert.ToInt32(balanceaddbox.Text);


        }

        private void Addmedicine_Click(object sender, EventArgs e)
        {
            //int price;

            medicine dummymed = new medicine(mednamebox.Text, Convert.ToInt32(medpricebox.Text), Convert.ToInt32(medquantitybox.Text), Convert.ToInt32(medcodebox.Text));
            medicineList.Add(dummymed);
            MessageBox.Show("medicine added ");
            account.account_balance = account.account_balance - Convert.ToInt32(medpricebox.Text);

            //dummymed.dummyaccount.decrea

        }

        private void salemed_Click(object sender, EventArgs e)
        {
            int medchkcode = Convert.ToInt32(checkcodebox.Text);
            int medchkquantity = Convert.ToInt32(medsalequantity.Text);

            foreach (medicine med in medicineList)
            {
                if ((med.getmedcode()) == medchkcode)
                {
                    if ((med.getmedquantity()) < 0)
                    {
                        MessageBox.Show("out of stock");
                        break;
                    }
                }
                med.decrease(medchkquantity);
                account.account_balance = account.account_balance - med.getmedquantity();

            }
        }

        private void showstock_Click(object sender, EventArgs e)
        {
            int medcodecmp = Convert.ToInt32(medstockbox.Text);
            foreach (medicine med in medicineList)
            {
                if ((med.getmedcode()) == medcodecmp)
                {
                    showQuantity.Text = "Quantity of" + med.getmedname() + "is " + med.getmedquantity();
                }

            }

        }

        private void showaccount_Click(object sender, EventArgs e)
        {
            accountbalance.Text = "account balance is"+ account.account_balance;
        }
    }
}
