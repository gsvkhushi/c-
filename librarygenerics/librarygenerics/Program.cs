using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== Library Management System =====");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Search Book by ID");
                Console.WriteLine("4. Remove Book by ID");
                Console.WriteLine("5. Check Total Books");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Book ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Book Name: ");
                            string name = Console.ReadLine();

                            library.AddBook(id, name);
                            break;

                        case 2:
                            library.DisplayBooks();
                            break;

                        case 3:
                            Console.Write("Enter Book ID to search: ");
                            int searchId = Convert.ToInt32(Console.ReadLine());
                            library.SearchBook(searchId);
                            break;

                        case 4:
                            Console.Write("Enter Book ID to remove: ");
                            int removeId = Convert.ToInt32(Console.ReadLine());
                            library.RemoveBook(removeId);
                            break;

                        case 5:
                            library.DisplayBookCount();
                            break;

                        case 6:
                            exit = true;
                            Console.WriteLine("Exiting Library Management System...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select between 1 and 6.\n");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value.\n");
                }
            }
        }
    }
}
