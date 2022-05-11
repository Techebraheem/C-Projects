using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        //attributes of a class Book

        public string title;
        public string author;
        public int pages;

        //using constructors to illustrate
        public Book(string aTitle, string aAuther, int aPages)
        {
            title = aTitle;
            author = aAuther;
            pages = aPages;
        }
    }
    class Programs
    {
        static void Main (string[] args)
        {

            // instatiating an object

            Book book1 = new Book("Harry Potter", "JK Rowlling", 400);

            Book book2 = new Book("Lord of the rings", "Tolkien", 700);

            Console.WriteLine(book1.title);
        }    
    }
}
