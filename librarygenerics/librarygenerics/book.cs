using System;

namespace LibraryManagementSystem
{
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public Book(int id, string name)
        {
            BookId = id;
            BookName = name;
        }

        public override string ToString()
        {
            return $"Book ID: {BookId}, Book Name: {BookName}";
        }
    }
}
