using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_task_5
{
    internal class Library
    {
      
        
            public List<Book> Books;

        public int BookCount;

        public Library()
            {
            

        Books = new List<Book>();
                BookCount = 0;
            }

            public void AddBook(Book book)
            {
                Books.Add(book);
            }
        

        public void Display()
        {
            Console.WriteLine("Complete List of Books");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            foreach (var book in Books)
            {
                Console.WriteLine("Title: {0}", book.Title);
                Console.WriteLine("Author: {0}", book.Author);
                Console.WriteLine("Genre: {0}", book.Genre);
                Console.WriteLine("Year: {0}", book.PublicationYear);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
            }
        }

        public void Search(string key)
        {
            foreach (var book in Books)
            {
                if (key == book.Title || key == book.Author || key == book.Genre)
                {
                    Console.WriteLine("Title: {0}", book.Title);
                    Console.WriteLine("Author: {0}", book.Author);
                    Console.WriteLine("Genre: {0}",book.Genre);
                    Console.WriteLine("Year: {0}", book.PublicationYear);
                    return;
                }
            }
            Console.WriteLine("Sorry, no matching book was found.");
        }
    }

}

