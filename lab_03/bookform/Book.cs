using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookform
{
    internal class Book
    {
        private int bookid;
        private string Bookname;
        public int Quantity;
        private string author;
        private string publisher;
        public Book(int bookid, string Bookname, int Quantity, string author, string publisher)
        {
            this.bookid = bookid;
            this.Bookname = Bookname;
            this.Quantity = Quantity;
            this.author = author;
            this.publisher = publisher;
        }
        public int Bookid
        {
            get { return bookid; }
            //set { bookid = value; }
        }
        public string get_bookname()
        {
            return Bookname; 
        }//public void set_bookname(string bookname)
        //{
        //    this.Bookname = bookname;
        //}
        public string Author
        {
            get { return author; }
            //set { author = value; }
        }
        
        public string get_publisher()
        {
            return publisher;
        }//public void set_publisher(string publisher)
        //{
        //    this.publisher = publisher;
        //}
        
        public void decrease()
        {
            Quantity = Quantity - 1;
        }
    }
}
