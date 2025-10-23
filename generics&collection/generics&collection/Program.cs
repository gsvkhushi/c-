using System;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== Student Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Remove Student by ID");
                Console.WriteLine("5. Display Topper");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Student ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Marks: ");
                            double marks = Convert.ToDouble(Console.ReadLine());

                            manager.AddStudent(id, name, marks);
                            break;

                        case 2:
                            manager.DisplayAll();
                            break;

                        case 3:
                            Console.Write("Enter Student ID to search: ");
                            int searchId = Convert.ToInt32(Console.ReadLine());
                            manager.SearchStudent(searchId);
                            break;

                        case 4:
                            Console.Write("Enter Student ID to remove: ");
                            int removeId = Convert.ToInt32(Console.ReadLine());
                            manager.RemoveStudent(removeId);
                            break;

                        case 5:
                            manager.DisplayTopper();
                            break;

                        case 6:
                            exit = true;
                            Console.WriteLine("Exiting Student Management System...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter 1-6.\n");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid numeric value.\n");
                }
            }
        }
    }
}
