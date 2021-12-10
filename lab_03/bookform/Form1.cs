using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookform
{
    public partial class Form1 : Form
    {
        List<Book> book_list = new List<Book>();
        List<user> user_list = new List<user>();
        public Form1()
        {
            
            InitializeComponent();
        }

        //private bool bookExist(int num)
        //{
        //    foreach(user user in user_list)
        //    {
        //        if(user.get_id() == num)
        //        {
        //            return true;
        //        }
        //    }return false;
        //}
        private void Save_user_Click(object sender, EventArgs e)
        {
            user dummyuser = new user(Convert.ToInt32(UserID.Text), UserAddress.Text, Username.Text);
            user_list.Add(dummyuser);
            MessageBox.Show("User added");

        }

        private void save_book_Click(object sender, EventArgs e)
        {
            Book dummmybook = new Book(Convert.ToInt32(BookID.Text), bookname.Text, Convert.ToInt32(Quantity.Text), bookauthor.Text, bookpublisher.Text);

            book_list.Add(dummmybook);
            MessageBox.Show("Book added");



        }

        private void Show_book_Click(object sender, EventArgs e)
        {
            int idcheck = Convert.ToInt32(UserID.Text);
            foreach (user user in user_list)
            {
                if (user.get_id() == idcheck)
                {
                    show_bookid.Items.Clear();
                    foreach (int books in user.userbook_list)
                    {
                        foreach(Book book in book_list)
                        {
                            if(book.Bookid == books)
                            {
                                show_bookid.Items.Add(Convert.ToString(books)+"\t"+book.get_bookname());
                            }
                        }
                    }
                    
                }
            }
        }

        private void showbook_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int bookidcheck = Convert.ToInt32(Bookid_check.Text);
            foreach (Book book in book_list)
            {
                if (book.Bookid == bookidcheck)
                {
                    flag = true;
                    outputbookid.Text = Convert.ToString(book.Bookid);
                    outoutbooktittle.Text = book.get_bookname();
                    outputbookauthor.Text = book.Author;
                    outputbookpublisher.Text = book.get_publisher();
                    outputquantity.Text = Convert.ToString(book.Quantity);
                }if(flag == false)
                {
                    MessageBox.Show("invalid input");
                }
            }
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            bool bflag = false;
            bool uflag = false;
            int borrowid = Convert.ToInt32(borrowuser.Text);
            int borrowbookid = Convert.ToInt32(borrowbook.Text);
            foreach (user user in user_list)
            {
                if (user.get_id() == borrowid)
                {
                    user.list_add(borrowbookid);
                    uflag = true;
                }
            }
            foreach (Book book in book_list)
            {
                if(book.Bookid == borrowbookid)
                {
                    if(book.Quantity == 0)
                    {
                        MessageBox.Show("Book is not available");
                        break;
                    }
                    book.decrease();
                    bflag = true;
                }
            }if(uflag == false)
            {
                MessageBox.Show("no such user");
            }else if (bflag == false)
            {
                MessageBox.Show("no such books");
            }
        }
    }
}
