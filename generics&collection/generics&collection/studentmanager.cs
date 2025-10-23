using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(int id, string name, double marks)
        {
            students.Add(new Student(id, name, marks));
            Console.WriteLine("Student added successfully.\n");
        }

        public void DisplayAll()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.\n");
                return;
            }

            Console.WriteLine("\nAll Students:");
            foreach (var student in students)
                Console.WriteLine(student);
            Console.WriteLine();
        }

        public void SearchStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
                Console.WriteLine($"No student found with ID {id}.\n");
            else
                Console.WriteLine($"Student found: {student}\n");
        }

        public void RemoveStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.StudentId == id);
            if (student == null)
            {
                Console.WriteLine($"No student found with ID {id}.\n");
                return;
            }

            students.Remove(student);
            Console.WriteLine($"Student with ID {id} removed successfully.\n");
        }

        public void DisplayTopper()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.\n");
                return;
            }

            var topper = students.OrderByDescending(s => s.Marks).First();
            Console.WriteLine($"Topper: {topper}\n");
        }
    }
}
