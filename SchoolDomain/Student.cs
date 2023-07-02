using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain
{
    public class Student
    {
        public static List<Student> Students;
        static Student()
        {
            //when the class gets initialised, the student list will be created
            Students = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Gpa { get; set; }
    }
}
