using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain
{
    public class Instructor
    {
        public static List<Instructor> Instructors;
        static Instructor()
        {
            //when the class gets initialised, the student list will be created
            Instructors = new List<Instructor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
