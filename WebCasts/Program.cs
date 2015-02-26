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
        private string _author;
        
      

        public string Author
        {
            get;
            set;
        }

        public int Id
        {
            set
            {
                if (value < 0)
                    throw new Exception("The book ID is not valid");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string BookName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The book name is not valid");
                this._bookName = value;
            }
            get
            {
                return this._bookName;
            }


        }    
        public int NoOfPages
        {
            get
            {
                return this._noOfPages;
            }
        }
        
    }

    class ExampleOne
    {
        public static void Main()
        {
            Book B1 = new Book();
            B1.Id=10;
            B1.BookName="HelloWorld";
            B1.Author = "John Metzbower";

           
            Console.WriteLine("Book ID is {0}", B1.Id);
            Console.WriteLine("Book name is {0}", B1.BookName);
            Console.WriteLine("Book has {0} pages", B1.NoOfPages);
            Console.WriteLine("The Author of the book is {0}", B1.Author);



            Console.ReadKey();
        }
    }
}
