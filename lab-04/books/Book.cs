using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    internal class Book
    {
        protected string bookID;
        protected string booktitle;
        protected string bookauthor;
        protected string bookpublisher;
        protected int bookquantity;

        public string setbookid()
        {
            return bookID;
        }
        public string setbooktitle()
        {
            return booktitle;
        }
        public string setbookauthor()
        {
            return bookauthor;
        }public string setpublisher() { return bookpublisher; }
        public int setbookquantity() { return bookquantity;}

        
        public int decrease()
        {
            bookquantity = bookquantity - 1;
            return bookquantity;
        }
    }
}
