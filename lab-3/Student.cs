
using System;
using System.Text;

namespace lab_3{

public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Course { get; set; }
        public string StudentID { get; set; } 
        public string Hobby { get; set; }

        public Student(string ln, string fn, int c, string id, string h)
        {
            LastName = ln;
            FirstName = fn;
            Course = c;
            StudentID = id;
            Hobby = h;
        }

        public override string ToString()
        {
            return $"| {LastName,-12} | {FirstName,-10} | {Course,-4} | {StudentID,-12} | {Hobby,-12} |";
        }
    }
}