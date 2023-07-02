using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain
{
    public class Course
    {
        public static List<Course> Courses;
        static Course()
        {
            //when the class gets initialised, the student list will be created
            Courses = new List<Course>();
        }
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public Instructor CourseInstructor { get; set; }
        public bool isDirty { get; set; } = false;
    }
}
