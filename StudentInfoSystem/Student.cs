using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    public partial class Student

    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public StudentDegrees Degree { get; set; }
        public string FacNumber { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public int Stream { get; set; }
        public StudentStatus Status { get; set; }
        public string Username { get; set; }

        public Student()
        {
        }

        public Student(string FirstName, string SurName, string LastName, string Faculty, string Specialty, StudentDegrees Degree, StudentStatus Status, string FacNumber, int Course, int Stream, int Group)
        {
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.LastName = LastName;
            this.Faculty = Faculty;
            this.Specialty = Specialty;
            this.Degree = Degree;
            this.Status = Status;
            this.FacNumber = FacNumber;
            this.Course = Course;
            this.Stream = Stream;
            this.Group = Group;
        }
    }
}
