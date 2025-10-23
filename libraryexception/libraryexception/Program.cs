using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(101);
            library.AddBook(102);
            library.AddBook(103);

            library.DisplayBooks();

            try
            {
                Console.Write("\nEnter Book ID to borrow: ");
                int bookId = Convert.ToInt32(Console.ReadLine());
                library.BorrowBook(bookId);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid numeric book ID.");
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Library operation complete.");
            }

            Console.WriteLine("\nUpdated Book List:");
            library.DisplayBooks();
        }
    }
}
