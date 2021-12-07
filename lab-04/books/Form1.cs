using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace books
{
    public partial class Form1 : Form
    {
        List <Studybook> stbooks = new List <Studybook> ();
        List <ResearchArticle> articles = new List <ResearchArticle> ();    
        public Form1()
        {
            InitializeComponent();
        }

        private void Addstudybook_Click(object sender, EventArgs e)
        {
            Studybook dummystudybook = new Studybook(BookIDtxt.Text, BookTittletxt.Text, Bookauthortxt.Text, Bookpublishertxt.Text, Convert.ToInt32(Bookquantitytxt.Text), BookISBNtxt.Text, BookGenretxt.Text);
            stbooks.Add (dummystudybook);
            MessageBox.Show("Book addeed");
        }

        private void Addresearcharticle_Click(object sender, EventArgs e)
        {
            ResearchArticle dummyarticle = new ResearchArticle(BookIDtxt.Text, BookTittletxt.Text, Bookauthortxt.Text, Bookpublishertxt.Text, Convert.ToInt32(Bookquantitytxt.Text), Convert.ToInt32(articleDOItxt.Text), articlepublisherdatetxt.Text, articleconferencetxt.Text);
            articles.Add (dummyarticle);
            MessageBox.Show("Book added");

        }

        private void borrowbookbutton_Click(object sender, EventArgs e)
        {
            string booknum = borrowbook.Text;
            foreach(Studybook books in stbooks)
            {
                if(books.setbookid() == booknum)
                {
                    if (books.setbookquantity() < 0)
                    {
                        MessageBox.Show("No more books");
                        break;
                    }
                    books.decrease();
                }
            }
        }

        private void borrowarticlebutton_Click(object sender, EventArgs e)
        {
            string articlenum = articleTxt.Text;
            foreach (ResearchArticle articls in articles)
            {
                if (articls.setbookid() == articlenum)
                {
                    if(articls.setbookquantity() < 0)
                    {
                        MessageBox.Show("No more books");
                    }
                    articls.decrease();
                }
            }

        }

        private void Showbook_Click(object sender, EventArgs e)
        {
            showbookslist.Items.Clear();
            showbookslist.Items.Add("ID    author    tittle    publisher    quantity   ISBN     Genre");
            foreach (Studybook books in stbooks)
            {
                showbookslist.Items.Add(books.setbookid() + "\t" + books.setbookauthor() + "\t" + books.setbooktitle() +"\t"+ books.setpublisher() +"\t"+ Convert.ToString(books.setbookquantity())+'\t'+Convert.ToInt32(books.getISBN())+"\t"+books.getGenre());
            }
        }

        private void showarticles_Click(object sender, EventArgs e)
        {
            Showarticleslist.Items.Clear();
            showbookslist.Items.Add("ID    author    tittle    publisher    quantity   DOI    articlepublisherdate      articleConference ");
            foreach (ResearchArticle articls in articles)
            {
                Showarticleslist.Items.Add(articls.setbookid() + "\t" + articls.setbookauthor() + "\t" + articls.setbooktitle() + "\t" + articls.setpublisher() + "\t" + Convert.ToString(articls.setbookquantity()) + '\t' + Convert.ToInt32(articls.getDOI()) + "\t" + articls.getarticlepublisherdate()+"\t"+articls.getarticleConference());
           
            }

        }
    }
    
}
