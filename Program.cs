using System.Diagnostics;

namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");
            Library library = new Library();
            Console.WriteLine("Are you Librarian or Regular user (L/R)");
            var userType = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();
            if (userType == 'L')
            {
                Librarian librarian = new Librarian(userName);
                Console.WriteLine($"Welcome {librarian.Name}");
                while (true)
                {
                    Console.WriteLine("\n1-Add Book\n2-Remove Book\n3-Display Books\n4-Exit");
                    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        continue;
                    }

                    if (choice == 4) break;

                    switch (choice)
                    {
                        case 1:
                            Book newBook = CreateBookFromInput();
                            if (newBook != null) librarian.AddBooks(newBook, library);
                            break;
                        case 2:
                            Book bookToRemove = CreateBookFromInput();
                            if (bookToRemove != null) librarian.RemoveBooks(bookToRemove, library);
                            break;
                        case 3:
                            librarian.DisplayBooks(library);
                            break;
                    }
                }
            }
            else if (userType == 'R')
            {
                LibraryUser user = new LibraryUser(userName);
                Console.WriteLine($"Welcome {user.Name}");
                while (true)
                {
                    Console.WriteLine("\n1-Borrow Book\n2-Display Books\n3-Exit");
                    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        continue;
                    }

                    if (choice == 3) break;

                    switch (choice)
                    {
                        case 1:
                            Book bookToBorrow = CreateBookFromInput();
                            if (bookToBorrow != null) user.BorrowBooks(bookToBorrow, library);
                            break;
                        case 2:
                            user.DisPlayBooks(library);
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a correct value (L/R)");
            }
        }
        static Book CreateBookFromInput()
        {
            try
            {
                Console.WriteLine("Enter Book Title:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter Book Author:");
                string author = Console.ReadLine();
                Console.WriteLine("Enter Book Year:");
                if (!int.TryParse(Console.ReadLine(), out int year))
                {
                    Console.WriteLine("Invalid year. Book creation failed.");
                    return null;
                }
                return new Book { Title = title, Author = author, Year = year };
            }
            catch (Exception)
            {
                Console.WriteLine("Error creating book. Please try again.");
                return null;
            }
        }
    }
}
