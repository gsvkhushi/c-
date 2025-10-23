using System;

namespace StudentManagementSystem
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student(int id, string name, double marks)
        {
            StudentId = id;
            Name = name;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"ID: {StudentId}, Name: {Name}, Marks: {Marks}";
        }
    }
}
