

namespace Library_management_system
{
    public class Librarian:User
    {
        public int EmployeeNumber {  get; set; }
        public Librarian(string name)
        {
            Name = name;
        }
        public void AddBooks(Book newBook,Library library)
        {
            library.Add(newBook);
            
        }
        public void RemoveBooks(Book book, Library library)
        {
            library.Remove(book);
        }
        public void DisplayBooks(Library library)
        {
            library.Display();
        }
    }
}
