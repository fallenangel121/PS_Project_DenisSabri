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
                FirstName = "Свети",
                SurName = "Пешо",
                LastName = "Калибрата",
                Facultee = "ФКСТ",
                Specialtee = "КСИ",
                FacNumber = "121218000",
                Degree = StudentDegrees.BACHELOR,
                Course = 5,
                Group = 51,
                Stream = 9,
                Status = StudentStatus.PREKASNAL,
                Username = "student1",
               
            });

            _TestStudents.Add(new Student
            {
                FirstName = "Мъстън",
                SurName = "Мъстънов",
                LastName = "Хюсеинов",
                Facultee = "ФКСТ",
                Specialtee = "КСИ",
                FacNumber = "128218060",
                Degree = StudentDegrees.BACHELOR,
                Course = 3,
                Group = 53,
                Stream = 9,
                Status = StudentStatus.ZAVERIL,
                Username = "student2",
                
            });
            _TestStudents.Add(new Student
            {
                FirstName = "Исус",
                SurName = "Ицо",
                LastName = "Пирона",
                Facultee = "ФЕЕТ",
                Specialtee = "ЕТ",
                FacNumber = "125218051",
                Degree = StudentDegrees.BACHELOR,
                Course = 6,
                Group = 50,
                Stream = 15,
                Status = StudentStatus.ZAVERIL,
                Username = "student3",
                
            });
            _TestStudents.Add(new Student
            {
                FirstName = "Жорж",
                SurName = "Стефанов",
                LastName = "Йорданов",
                Facultee = "фаГИОПМ",
                Specialtee = "НА",
                FacNumber = "126218066",
                Degree = StudentDegrees.BACHELOR,
                Course = 7,
                Group = 21,
                Stream = 12,
                Status = StudentStatus.ZAVERIL,
                Username = "student4",
                
            });
        }
    }
}
