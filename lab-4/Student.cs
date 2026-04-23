using System;

namespace lab_4
{

    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string StudentId { get; set; }
        public string GroupName { get; set; }

        public Student(string lastName, string firstName, string studentId, string groupName)
        {
            LastName = lastName;
            FirstName = firstName;
            StudentId = studentId;
            GroupName = groupName;
        }


        public override string ToString()
        {
            return $"{LastName,-12} {FirstName,-10} | Квиток: {StudentId,-8} | Група: {GroupName}";
        }
    }
}