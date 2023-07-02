//responsible for recieving requests from
//presentation layer and sending it back
//web service running on web server
using SchoolBusiness;

namespace SchoolService
{
    public class Service
    {
        public void Controller(string methodName, string[] vars)
        {
            try
            {
                var business = new Business();
                switch (methodName.ToLower())
                {
                    case "createstudent":
                        int studentId = Convert.ToInt32(vars[0]);
                        string studentName = vars[1];
                        float gpa = (float)Convert.ToDouble(vars[2]);
                        business.AddStudent(studentId, studentName, gpa);
                        break;
                    case "createinstructor":
                        int instructorId = Convert.ToInt32(vars[0]);
                        string instructorName = vars[1];
                        business.AddInstructor(instructorId, instructorName);
                        break;
                    case "createcourse":
                        int courseId = Convert.ToInt32(vars[0]);
                        string courseName = vars[1];
                        int creditHours = Convert.ToInt32(vars[2]);
                        business.AddCourse(courseId, courseName, creditHours);
                        break;
                    case "addstudenttocourse":
                        int studentIdAssigned = Convert.ToInt32(vars[0]);
                        int courseIdRegistered = Convert.ToInt32(vars[1]);
                        business.AddStudentToCourse(studentIdAssigned, courseIdRegistered);
                        break;
                    case "addinstructortocourse":
                        int course = Convert.ToInt32(vars[0]);
                        int instructor = Convert.ToInt32(vars[1]);
                        business.AddInstructorToCourse(course, instructor);
                        break;
                    case "addstudentgrade":
                        int studentIdGrade = Convert.ToInt32(vars[0]);
                        int courseIdGrade = Convert.ToInt32(vars[1]);
                        string courseGrade = vars[2];
                        business.AddGradeToStudent(studentIdGrade, courseIdGrade, courseGrade);
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"This method had a problem : {methodName}"+ex.Message);
            }
        }
    }
}