namespace StudentManagement
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student(int studentID, string name, double marks)
        {
            StudentID = studentID;
            Name = name;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {Name}, Marks: {Marks}";
        }
    }
}
