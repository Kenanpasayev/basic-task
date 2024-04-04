using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Group
    {
        int _studentlimit;
        public string GroupNo { get; set; }
        private Student[] students;
        public Group()
        {
            students = new Student[0];

        }
        public int StudentLimit
        {
            get
            {
                return _studentlimit;
            }
            set
            {
                if (value > 5 && value < 18)
                {
                    _studentlimit = value;
                }
            }
        }
        public bool CheckGroupNo(string GroupNo)
        {
            return GroupNo.Length == 5 && char.IsUpper(GroupNo[0]) && char.IsUpper(GroupNo[1]) && char.IsDigit(GroupNo[2]) && char.IsDigit(GroupNo[3]) && char.IsDigit(GroupNo[4]);
        }
        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
        }
        public void GetAllStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Id:{student.Id},Fullname:{student.Fullname},Point:{student.Point}");
            }
        }
        public Student GetStudent(int id)
        {
            if (id == null)
            {
                return null;
            }
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
