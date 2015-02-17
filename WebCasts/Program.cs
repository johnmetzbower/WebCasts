using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCasts
{
    class Book
    {
        private int _id;
        private string _bookName;
        private int _noOfPages = 250;
        
        public void SetId(int Id)
        {
            if (Id < 0)
                throw new Exception("The book ID is not valid");
            this._id = Id;
        }
        public int GetId(int Id)
        {
            return this._id;
        }
        public void SetBookName(string Bookname)
        {
            if (string.IsNullOrEmpty(Bookname))
                throw new Exception("The book name is not valid");
            this._bookName = Bookname;
        }
        public int GetBookName(String Bookname)
        {
            return this._id;
        }
    }

    class ExampleOne
    {
        public static void Main()
        {
            Book B = new Book();
            B.SetId(10);
            B.SetBookName(null);
            
            Console.WriteLine("Book ID is {0}", B.SetId());
            Console.WriteLine("Book name is {0}", B.SetBookName());

           

            Console.ReadKey();
        }
    }
}
