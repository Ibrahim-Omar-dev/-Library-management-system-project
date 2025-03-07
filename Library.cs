

using System.ComponentModel;

namespace Library_management_system
{
    public class Library
    {
        private List<Book> books;
        private List<Book> borrowedBooks;

        public Library()
        {
            books= new List<Book>();
            borrowedBooks = new List<Book>();
        }

        public void Add(Book book)
        {
            if (book != null)
            {
                books.Add(book);
            }
            Console.WriteLine("Add book successful");
        }
        public void Remove(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("Cannot remove a null book.");
                return;
            }
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine("Remove Book Successful");
            }
            else
            {
                Console.WriteLine("Book was not found. Please try again.");
            }
        }
        public void Display()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        public bool Borrow(Book book)
        {
            if (books != null && books.Contains(book))
            {
                books.Remove(book);
                borrowedBooks.Add(book);
                return true;
            }
            return false;
        }
        public bool ReturnBook(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("Cannot return a null book.");
                return false;
            }
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                books.Add(book);
                Console.WriteLine("Book returned successfully.");
                return true;
            }
            Console.WriteLine("Book was not borrowed.");
            return false;
        }
    }
}
