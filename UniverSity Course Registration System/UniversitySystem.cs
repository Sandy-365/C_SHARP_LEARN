using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            if (AvailableCourses.ContainsKey(code))
            {
                Console.WriteLine("Course already exists");
                return;
            }

            AvailableCourses.Add(code, new Course(code, name, credits, maxCapacity, prerequisites));
            // throw new NotImplementedException();
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if (Students.ContainsKey(id))
            {
                Console.WriteLine("Student already exists");
                return;
            }

            Students.Add(id, new Student(id, name, major, maxCredits, completedCourses));
            // throw new NotImplementedException();
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages

            // validating
            if (!(AvailableCourses.ContainsKey(courseCode) && Students.ContainsKey(studentId)))
                return false;

            Course course = AvailableCourses[courseCode];
            bool res = Students[studentId].AddCourse(course);

            if (res)
                Console.WriteLine("Course added");
            else
                Console.WriteLine("Course not added");

            return true;
            // throw new NotImplementedException();
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if (!Students.ContainsKey(studentId))
                return false;

            bool res = Students[studentId].DropCourse(courseCode);

            if (!res)
                Console.WriteLine("Student not having this course");
            else
                Console.WriteLine("Drop successful");

            return true;
            // throw new NotImplementedException();
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            Console.WriteLine("Available Courses:");
            foreach (KeyValuePair<string, Course> data in AvailableCourses)
            {
                Course res = data.Value;
                Console.WriteLine(
                    data.Key + " " +
                    res.CourseName + " " +
                    res.Credits + " " +
                    res.GetEnrollmentInfo()
                );
            }
            // throw new NotImplementedException();
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found");
                return;
            }
            Students[studentId].DisplaySchedule();


            // throw new NotImplementedException();
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            Console.WriteLine($"Total Students: {Students.Count}");
            Console.WriteLine($"Total Courses: {AvailableCourses.Count}");
            
            // throw new NotImplementedException();
        }
    }
}
