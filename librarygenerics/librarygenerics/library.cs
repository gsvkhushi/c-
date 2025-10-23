using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(int id, string name)
        {
            books.Add(new Book(id, name));
            Console.WriteLine("Book added successfully.\n");
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.\n");
                return;
            }

            Console.WriteLine("\nBooks in Library:");
            foreach (var book in books)
                Console.WriteLine(book);
            Console.WriteLine();
        }

        public void SearchBook(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            if (book == null)
                Console.WriteLine($"Book with ID {id} not found.\n");
            else
                Console.WriteLine($"Book Found: {book}\n");
        }

        public void RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            if (book == null)
            {
                Console.WriteLine($"Book with ID {id} not found.\n");
                return;
            }

            books.Remove(book);
            Console.WriteLine($"Book with ID {id} removed successfully.\n");
        }

        public void DisplayBookCount()
        {
            Console.WriteLine($"Total books available: {books.Count}\n");
        }
    }
}
