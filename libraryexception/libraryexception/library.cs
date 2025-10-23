using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message) { }
    }

    class Library
    {
        private List<int> books = new List<int>();

        public void AddBook(int id)
        {
            books.Add(id);
        }

        public void BorrowBook(int id)
        {
            if (!books.Contains(id))
                throw new BookNotFoundException($"Book with ID {id} not found in library.");

            books.Remove(id);
            Console.WriteLine($"Book with ID {id} borrowed successfully.");
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }

            Console.WriteLine("Available Books:");
            foreach (int id in books)
            {
                Console.WriteLine($"Book ID: {id}");
            }
        }
    }
}
