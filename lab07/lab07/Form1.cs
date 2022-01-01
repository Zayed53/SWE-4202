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
        CSE dummycse = new CSE();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (studentradio.Checked)
            {
                Student dummystudent = new Student(namebox.Text, Convert.ToInt32(Regnobox.Text), Convert.ToInt32(Contactnobox.Text), Emailbox.Text);
                if (Begginerradio.Checked)
                {
                    dummystudent.level = "Beginner";
                }
                else if (Intermediateradio.Checked)
                {
                    dummystudent.level = "Intermediate";
                }
                else if (Advanceradio.Checked)
                {
                    dummystudent.level = "Advance";
                }
                dummycse.studentslist.Add(dummystudent);
                studentenrollcombo.Items.Add(dummystudent.regno);
            }
            else if (Professionalradio.Checked)
            {
                Professional dummyprofessional = new Professional(namebox.Text, Convert.ToInt32(Regnobox.Text), Convert.ToInt32(Contactnobox.Text), Emailbox.Text);
                if (Begginerradio.Checked)
                {
                    dummyprofessional.level = "Beginner";
                }
                else if (Intermediateradio.Checked)
                {
                    dummyprofessional.level = "Intermediate";
                }
                else if (Advanceradio.Checked)
                {
                    dummyprofessional.level = "Advance";
                }
                dummycse.professionalslist.Add(dummyprofessional);
                studentenrollcombo.Items.Add(dummyprofessional.regno);

            }
        }

        private void addcourse_Click(object sender, EventArgs e)
        {
            //Course.coursefee = Convert.ToInt32(Coursefeebox.Text);
            Course dummycourse = new Course(Coursetittlebox.Text, Convert.ToInt32(Coursefeebox.Text));
            if (Coursebegginerradio.Checked)
            {
                dummycourse.courselevel = "Beginner";
            }
            else if (Coursebegginerradio.Checked)
            {
                dummycourse.courselevel = "Intermediate";
            }
            else if (Coursebegginerradio.Checked)
            {
                dummycourse.courselevel = "Advance";
            }
            dummycse.courselist.Add(dummycourse);
            CourseEnrollcombo.Items.Add(dummycourse.coursetittle);
            //Student.studentcoursefee = Convert.ToInt32(Coursefeebox.Text);
        }
        private void CourseEnrollcombo_Click(object sender, EventArgs e)
        {
            foreach (Student student in dummycse.studentslist)
            {
                int regcheck = Convert.ToInt32(studentenrollcombo.Text);
                if (student.regno == regcheck)
                {
                    //student.studentcourses.Add(CourseEnrollcombo.Text);

                    student.studentcoursefee = Convert.ToInt32(Coursefeebox.Text);
                    Coursefeelbl.Text = Convert.ToString(student.studentcoursefee);
                }
            }
            foreach (Professional pro in dummycse.professionalslist)
            {
                int regcheck = Convert.ToInt32(studentenrollcombo.Text);
                if (pro.regno == regcheck)
                {
                    pro.procourses.Add(CourseEnrollcombo.Text);

                    pro.procoursefee = (float)((Convert.ToInt32(Coursefeebox.Text)) * 0.1) + (Convert.ToInt32(Coursefeebox.Text));
                    Coursefeelbl.Text = (Convert.ToString(pro.procoursefee));
                }
            }
        }
        private void pay_and_enroll_Click(object sender, EventArgs e)
        {
            int regcheck = Convert.ToInt32(studentenrollcombo.Text);
            foreach (Student student in dummycse.studentslist)
            {
                if (student.regno == regcheck)
                {
                    student.studentcourses.Add(CourseEnrollcombo.Text);

                    //student.studentcoursefee = Convert.ToInt32(Coursefeebox.Text);
                    //Coursefeelbl.Text = Convert.ToString(student.studentcoursefee);
                }

            }
            foreach (Professional pro in dummycse.professionalslist)
            {
                if (pro.regno == regcheck)
                {
                    pro.procourses.Add(CourseEnrollcombo.Text);

                    //pro.procoursefee = (float)((Convert.ToInt32(Coursefeebox.Text)) * 0.1)+ (Convert.ToInt32(Coursefeebox.Text));
                    //Coursefeelbl.Text = (Convert.ToString(pro.procoursefee));
                }

            }
        }

        private void showhistory_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(checkstudenthistorybox.Text);
            foreach (Student student in dummycse.studentslist)
            {
                if (number == student.regno)
                {
                    foreach (string course in student.studentcourses)
                    {
                        listBox1.Items.Add(Convert.ToString(student.regno) + '\t' + course);
                    }
                }
            }
            foreach (Professional pro in dummycse.professionalslist)
            {
                if (number == pro.regno)
                {
                    foreach (string course in pro.procourses)
                    {
                        listBox1.Items.Add(Convert.ToString(pro.regno) + '\t' + course);
                    }
                }
            }
        }

        
    }
}
