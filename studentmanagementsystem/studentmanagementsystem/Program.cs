using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Remove Student by ID");
                Console.WriteLine("5. Display Topper");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayAllStudents();
                        break;
                    case 3:
                        SearchStudentByID();
                        break;
                    case 4:
                        RemoveStudentByID();
                        break;
                    case 5:
                        DisplayTopper();
                        break;
                    case 6:
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose between 1 and 6.");
                        break;
                }

            } while (choice != 6);
        }

        static void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid Student ID.");
                return;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            Console.Write("Enter Marks: ");
            if (!double.TryParse(Console.ReadLine(), out double marks))
            {
                Console.WriteLine("Invalid Marks.");
                return;
            }

            students.Add(new Student(id, name, marks));
            Console.WriteLine("Student added successfully.");
        }

        static void DisplayAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n--- All Students ---");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void SearchStudentByID()
        {
            Console.Write("Enter Student ID to search: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid Student ID.");
                return;
            }

            var student = students.Find(s => s.StudentID == id);

            if (student != null)
            {
                Console.WriteLine("Student Found:");
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void RemoveStudentByID()
        {
            Console.Write("Enter Student ID to remove: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid Student ID.");
                return;
            }

            var student = students.Find(s => s.StudentID == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void DisplayTopper()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            var topper = students.OrderByDescending(s => s.Marks).First();
            Console.WriteLine("Topper of the class:");
            Console.WriteLine(topper);
        }
    }
}
