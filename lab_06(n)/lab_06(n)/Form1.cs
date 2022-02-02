using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_06_n_
{
    public partial class Form1 : Form
    {
        laundry dummylaundry = new laundry();
        int shirtbill, pantbill, suitbill;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        

        private void create_account_Click(object sender, EventArgs e)
        {
            user dummyuser = new user(Convert.ToInt32(useridbox.Text), namebox.Text, addressbox.Text);
            dummylaundry.userlist.Add(dummyuser);

        }

        

        private void addorder_Click(object sender, EventArgs e)
        {
            
            foreach(user user in dummylaundry.userlist)
            {
                if(user.getUser_id()== Convert.ToInt32(useridcheckbox.Text))
                {
                    user.setvalue(Convert.ToInt32(shirtbox.Text), Convert.ToInt32(pantbox.Text), Convert.ToInt32(suitbox.Text), shirtstatcombox.Text, pantstatcombox.Text, suitstatcombox.Text);
                    user.vardate = dateTimePicker1.Value.ToString();
                    if(shirtstatcombox.Text== "Iron") { shirtbill = Convert.ToInt32(shirtbox.Text) * 5; }
                    else if (shirtstatcombox.Text == "Wash") { shirtbill = Convert.ToInt32(shirtbox.Text) * 10; }
                    else if (shirtstatcombox.Text == "Both") { shirtbill = Convert.ToInt32(shirtbox.Text) * 15; }

                    if (pantstatcombox.Text == "Iron") { pantbill = Convert.ToInt32(pantbox.Text) * 5; }
                    else if (pantstatcombox.Text == "Wash") { pantbill = Convert.ToInt32(pantbox.Text) * 10; }
                    else if (pantstatcombox.Text == "Both") { pantbill = Convert.ToInt32(pantbox.Text) * 15; }

                    user.owner_bill = shirtbill + pantbill + suitbill;
                    //user.owner_bill= Convert.ToInt32(shirtbox.Text)*10+ Convert.ToInt32(pantbox.Text)*5, Convert.ToInt32(suitbox.Text)
                }
            }
        }
        private void showuserstat_Click(object sender, EventArgs e)
        {
            foreach (user user in dummylaundry.userlist)
            {
                if (user.getUser_id() == Convert.ToInt32(checkforowner.Text))
                {
                    user.userstat = statuscombo.Text;
                }
            }

        }




        private void showbox_Click(object sender, EventArgs e)
        {
            int check = Convert.ToInt32(userhistorycheckbox.Text);
            foreach (user uses in dummylaundry.userlist)
            {
                if (uses.getUser_id() == check)
                {
                    userhistorylist.Items.Add(Convert.ToInt32(uses.getShirtqnt()) + "\t" + uses.getShirtstat());
                    userhistorylist.Items.Add(Convert.ToInt32(uses.getPantqnt()) + "\t" + uses.getPantstat());
                    userhistorylist.Items.Add(Convert.ToInt32(uses.getSuitsqnt()) + "\t" + uses.getSuitstat());
                    userstatshowlabel.Text = uses.userstat.ToString();
                    if(userstatshowlabel.Text== "delivered")
                    {
                        useraccount.Text = Convert.ToString(uses.owner_bill);
                    }else if(userstatshowlabel.Text== "pending")
                    {
                        useraccount.Text = "will take more than 6 days";
                    }else if(userstatshowlabel.Text == "processing")
                    {
                        useraccount.Text = "will be delivered within 6 days";
                    }
                }
            }
        }
        
    }
}
