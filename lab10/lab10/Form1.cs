using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        office dummyoffice = new office();
        List<string> log = new List<string>();
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\employees.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    employee ndummyemp = new employee(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[9], values[10]);
                    dummyoffice.Employees.Add(ndummyemp);
                }
            }
            foreach(employee newemp in dummyoffice.Employees)
            {
                namea.Items.Add(newemp.Id+"\t"+newemp.Lname+"\t"+newemp.Lname);
            }
        }

        private void searchId_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string check = searchbox.Text;
            string path = @"c:\show.txt";
            //using (StreamWriter sw = File.CreateText(path))
            foreach (employee newemp in dummyoffice.Employees)
            {
                if(check == newemp.Id)
                {
                    Showhistory.Items.Add(newemp.FName);
                    Showhistory.Items.Add(newemp.Lname);
                    Showhistory.Items.Add(newemp.email);
                    flag = 1;
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(newemp.Id+newemp.FName+newemp.Lname);//append
                    }
                    //log.Add(newemp.Id + newemp.FName + newemp.Lname);
                }
                
                //foreach(String his in log)
                //{
                //    //using (StreamWriter sw = File.CreateText(path))
                //    {
                //        sw.WriteLine(his);
                //    }

                //}

                //if (!File.Exists(path))
                //{
                // Create a file to write to.

                //}
            }
            if (flag != 1)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(Convert.ToString(check) + "  NO");
                }
                //log.Add(Convert.ToString(check) + "  NO");

            }
        }
        //office dummyoffice=new office();
        // List<string> listA = new List<string>();
        //List<string> listB = new List<string>();




    }
}
