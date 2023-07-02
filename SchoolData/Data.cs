//data layer
using SchoolDomain;

namespace SchoolData
{
    public class Data
    {
        public void CreateStudent(Student student)
        {
            Student.Students.Add(student);
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
        }
        public void CreateInstructor(Instructor instructor)
        {
            Instructor.Instructors.Add(instructor);
            Console.WriteLine(instructor.Name);
        }
        public void SaveCourse(Course course)
        {
            if (course.isDirty)
            {
                for(int i = 0;i<Course.Courses.Count;i++)
                {
                    if (Course.Courses[i].Id == course.Id)
                    {
                        course.isDirty = false;
                        Course.Courses[i] = course;
                        Console.WriteLine("Course modified");
                        return;
                    }
                }
            }
            Course.Courses.Add(course);
            Console.WriteLine(course.CourseName);

        }
        public void SaveStudentCourse(StudentCourse studentcourse)
        {
            if(studentcourse.isDirty)
            {
                for(int i = 0;i<StudentCourse.StudentCourses.Count;i++)
                {
                    if (StudentCourse.StudentCourses[i].student.Id == studentcourse.student.Id &&
                        StudentCourse.StudentCourses[i].course.Id == studentcourse.course.Id)
                    {
                        studentcourse.isDirty = false;
                        StudentCourse.StudentCourses[i] = studentcourse;
                        Console.WriteLine("student course modified");
                        return;
                    }
                }
            }
            StudentCourse.StudentCourses.Add(studentcourse);
            Console.WriteLine(studentcourse.student);
        }
        public Student GetStudentById(int id)
        {
            foreach(var student in Student.Students)
            {
                if(student.Id == id) return student;
            }
            return null;
        }
        public Instructor GetInstructorById(int id)
        {
            foreach(var instructor in Instructor.Instructors)
            {
                if (instructor.Id == id) { return instructor; }
            }
            return null;
        }
        public Course GetCourseById(int id)
        {
            foreach(var  course in Course.Courses)
            {
                if(course.Id == id) return course;
            }
            return null;
        }
        public StudentCourse GetStudentCourseById(int studentid, int courseid)
        {
            foreach (var studentcourse in StudentCourse.StudentCourses)
            {
                if (studentcourse.student.Id == studentid && 
                    studentcourse.course.Id == courseid) return studentcourse;
            }
            return null;
        }
    }
}