using System;

namespace CustomTypes
{
    public class Student
    {
        public Student()
        {

        }
        public Student(int id, string name, double gPA)
        {
            Id = id;
            Name = name;
            GPA = gPA;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public override string ToString()
        {
            return $"{Id,-5} {Name,-20} {GPA,-5}";
        }
    }
}
