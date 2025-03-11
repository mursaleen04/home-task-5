using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_task_5
{
    internal class program
    {
        static void Main(string[] args)
        {
         
                Book book1 = new Book { Title = "Raja Gidh", Author = "Bano Qudsia", Genre = "Philosophical Fiction", PublicationYear = 1981 };
                Book book2 = new Book { Title = "Peer-e-Kamil", Author = "Umera Ahmed", Genre = "Spiritual Fiction", PublicationYear = 2004 };
                Book book3 = new Book { Title = "Zaviya", Author = "Ashfaq Ahmed", Genre = "Motivational", PublicationYear = 1997 };

                Library library = new Library();
                library.AddBook(book1);
                library.AddBook(book2);
                library.AddBook(book3);

                library.Display();

                Console.WriteLine("Type a title, author, or genre to find a book:");
                string key = Console.ReadLine();
                library.Search(key);
            }
        }

    }

