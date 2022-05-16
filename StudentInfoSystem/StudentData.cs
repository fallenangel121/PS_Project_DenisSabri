using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    class StudentData
    {
        static List<Student> _TestStudents = new List<Student>();
        static public List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return _TestStudents;
            }
            private set { }
        }

        static private void ResetTestStudentData()
        {
            _TestStudents.Clear();

            _TestStudents.Add(new Student
            {
                FirstName = "Ivan",
                SurName = "Filipov",
                LastName = "Filipov",
                Faculty = "FCST",
                Specialty = "KSI",
                FacNumber = "121219111",
                Degree = StudentDegrees.BACHELOR,
                Course = 1,
                Group = 30,
                Stream = 12,
                Status = StudentStatus.PREKASNAL,
                Username = "student1",
               
            });

            _TestStudents.Add(new Student
            {
                FirstName = "Denis",
                SurName = "Selchuk",
                LastName = "Sabri",
                Faculty = "FKST",
                Specialty = "KSI",
                FacNumber = "121219118",
                Degree = StudentDegrees.BACHELOR,
                Course = 3,
                Group = 31,
                Stream = 9,
                Status = StudentStatus.ZAVERIL,
                Username = "student2",
                
            });
            _TestStudents.Add(new Student
            {
                FirstName = "Tihomir",
                SurName = "Geshov",
                LastName = "Semitliev",
                Faculty = "FKST",
                Specialty = "ITI",
                FacNumber = "121219123",
                Degree = StudentDegrees.BACHELOR,
                Course = 3,
                Group = 36,
                Stream = 10,
                Status = StudentStatus.ZAVERIL,
                Username = "student3",
                
            });
            _TestStudents.Add(new Student
            {
                FirstName = "Alexandar",
                SurName = "Viktorov",
                LastName = "Popivanov",
                Faculty = "FaGIOPM",
                Specialty = "HA",
                FacNumber = "121219001",
                Degree = StudentDegrees.BACHELOR,
                Course = 2,
                Group = 20,
                Stream = 7,
                Status = StudentStatus.ZAVERIL,
                Username = "student4",
                
            });
        }
    }
}
