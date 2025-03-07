
namespace Library_management_system
{
    public class LibraryUser:User
    {
        private LibraryCard Card { get; set; }

        public LibraryUser(string name)
        {
            Name = name;
        }
        public bool BorrowBooks(Book book,Library library)
        {
            return library.Borrow(book);
        }
    }
}
