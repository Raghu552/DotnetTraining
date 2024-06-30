using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author: {AuthorName}");
        }
    }
    public class BookShelf
    {
        private Books[] books; 
        private int maxSize; 
        public BookShelf(int size)
        {
            maxSize = size;
            books = new Books[maxSize];
        }
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < maxSize)
                {
                    return books[index];
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range for the BookShelf.");
                }
            }
            set
            {
                if (index >= 0 && index < maxSize)
                {
                    books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range for the BookShelf.");
                }
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Books on the BookShelf:");
            for (int i = 0; i < maxSize; i++)
            {
                if (books[i] != null)
                {
                    Console.Write($"{i + 1}. ");
                    books[i].Display();
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf(5);
            shelf[0] = new Books("Bhagavathgeeta", "Krishna");
            shelf[1] = new Books("Half Girlfriend", "Bollywood Director");
            shelf[2] = new Books("Game of Thrones", "American");
            shelf[3] = new Books("Think like a Monk", "Richard");
            shelf[4] = new Books("The mysterious", "Raghu");
            shelf.DisplayBooks();
            Console.Read();
        }
    }
}
