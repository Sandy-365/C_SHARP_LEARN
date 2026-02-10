using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            // TODO: Return sum of credits of all RegisteredCourses
            int total = 0;
            foreach (Course course in RegisteredCourses)
            {
                total += course.Credits;
            }
            return total;

            //throw new NotImplementedException();
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            // 2. Total credits + course credits <= MaxCredits
            // 3. Course prerequisites must be satisfied
            if (RegisteredCourses.Contains(course))
                return false;

            if (GetTotalCredits() + course.Credits > MaxCredits)
                return false;

            if (!course.HasPrerequisites(CompletedCourses))
                return false;

            return true;

            // throw new NotImplementedException();
        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()
            bool res = CanAddCourse(course);
            if (!res)
                return false;

            course.EnrollStudent();
            RegisteredCourses.Add(course);
            return true;
            // throw new NotImplementedException();

        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            // 2. Remove from RegisteredCourses
            // 3. Call course.DropStudent()

            Course removeCourse = null;

            foreach (Course course in RegisteredCourses)
            {
                if (course.CourseCode == courseCode)
                {
                    removeCourse = course;
                    break;
                }
            }

            if (removeCourse == null)
                return false;

            RegisteredCourses.Remove(removeCourse);
            removeCourse.DropStudent();
            return true;
            // throw new NotImplementedException();
        }

        public void DisplaySchedule()
        {
            // TODO:
            // Display course code, name, and credits
            // If no courses registered, display appropriate message
            if (RegisteredCourses.Count == 0)
            {
                Console.WriteLine("No courses registered");
                return;
            }

            Console.WriteLine(Name + " - " + Major);
            foreach (Course course in RegisteredCourses)
            {
                Console.WriteLine(course.CourseCode + " " + course.CourseName + " " + course.Credits);
            }

            Console.WriteLine("Total Credits: " + GetTotalCredits());

            // throw new NotImplementedException();
        }
    }
}
