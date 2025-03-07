

namespace Library_management_system
{
    public abstract class User
    {
        public string Name { get; set; }

        public void DisPlayBooks(Library library)
        {
            library.Display();
        }
    }
}
