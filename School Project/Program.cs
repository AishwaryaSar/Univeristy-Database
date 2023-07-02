using SchoolService;
using System;
namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            service.Controller("CreateStudent",new string[] { "1","Ash","0"}); 
            service.Controller("CreateStudent", new string[] { "1", "Ash", "0" });
            service.Controller("CreateInstructor", new string[] { "1", "Sarv" });
            service.Controller("CreateCourse", new string[] { "1", "Computer Science", "30" });
            service.Controller("AddStudentToCourse",new string[] {"1","1"});
            service.Controller("AddInstructorToCourse", new string[] { "1", "1" });
            service.Controller("AddStudentGrade", new string[] { "1", "1", "A" });
        }
    }
}