using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final
{
    public partial class Form1 : Form
    {
        //Class dummyclass = new Class();
        List<Students> lststudents = new List<Students>();
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\studentlist.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    List <string> file = new List<string>();
                    
                    foreach(var value in values)
                    {
                        if( value != null)
                        {
                            file.Add(value);
                        }
                        else
                        {
                            file.Add("0");
                        }

                    }

                    Students dummystudent = new Students();
                    dummystudent.Id=file[0];
                    //dummystudent.Name= file[1];
                    dummystudent.attendance= file[2];
                    //dummystudent.quiz1=file[3];
                    //dummystudent.quiz2=file[4];
                    //dummystudent.quiz3=file[5];
                    //dummystudent.quiz[3]=Convert.ToInt32(file[6]);
                    dummystudent.mid= file[7];
                    dummystudent.final = file[8];
                    dummystudent.viva= file[9];

                    //dummystudent.resultpublisher();

                    //dummystudent.gradegen();

                    lststudents.Add(dummystudent);

                    foreach (Students newemp in lststudents)
                    {
                        namea.Items.Add(newemp.Id + "\t" + newemp.Name + "\t" + newemp.percentage+"\t"+newemp.grade);
                    }





                    //dummyoffice.Employees.Add(ndummyemp);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchId_Click(object sender, EventArgs e)
        {
            string check = searchbox.Text;
            var students = from student in lststudents
                           where student.Id == check
                           select student;
            foreach(var student in students)
            {
                Showhistory.Items.Add("Attendance="+student.attendance+"\n"+"mid="+student.mid+"\n"+"final="+student.final+"\n"+"percentage="+student.percentage+"\n"+"Grade="+student.grade);
            }
        }
    }
}
