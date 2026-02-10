using System;
using System.Collections.Generic;
using System.Linq;
using University_Course_Registration_System;


namespace University_Course_Registration_System
{
    // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static UniversitySystem system = new UniversitySystem();
        static void _1_addingCourse()
        {
            Console.Write("Enter Course Code: ");
            string courseCode = Console.ReadLine();
            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter Credits: ");
            int credits = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Max Capacity(default 50): ");
            int maxCap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Prerequisites(comma-separated, or Enter for none): ");
            string prereq = Console.ReadLine();
            string[] preList = prereq.Split(',');
            List<string> preResult = new List<string>(preList);
            system.AddCourse(courseCode, courseName, credits, maxCap, preResult);
            Console.WriteLine("Course " + courseCode + " added successfully");
        }

        static void _2_addingStudent()
        {
            Console.Write("Enter Student ID: ");
            string stuId = Console.ReadLine();
            Console.Write("Enter Name: ");
            string stuName = Console.ReadLine();
            Console.Write("Enter Major: ");
            string stuMajor = Console.ReadLine();
            Console.Write("Enter Max Credits(default 18): ");
            int maxCredits = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Completed Courses(comma - separated, or Enter for none): ");
            string stuCourses = Console.ReadLine();
            string[] stuCoursesArr = stuCourses.Split(',');
            List<string> stuCoursesList = new List<string>(stuCoursesArr);

            system.AddStudent(stuId, stuName, stuMajor, maxCredits, stuCoursesList);
            Console.WriteLine("Student " + stuId + "  added successfully");
        }


        static void _3_registeringStuCourse()
        {
            Console.Write("Enter Student ID: ");
            string stuId = Console.ReadLine();

            Console.Write("Enter Course Code: ");
            string courseId = Console.ReadLine();

            bool res = system.RegisterStudentForCourse(stuId, courseId);
            if (res)
            {
                Console.WriteLine("Data added to student");
            }
            else
            {
                Console.WriteLine("Student or course not exist");
            }
        }

        static void _4_dropingStuCourse()
        {
            Console.Write("Enter student Id ::>> ");
            string stuId = Console.ReadLine();

            Console.Write("Enter course Code ::>> ");
            string courseCode = Console.ReadLine();

            bool res = system.DropStudentFromCourse(stuId, courseCode);
            if (res)
            {
                Console.WriteLine("Student not having this course");
            }
            else
            {
                Console.WriteLine("Drop successfull");
            }
        }

        static void Main()
        {
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                int ch = 9;
                try
                {
                    ch = Convert.ToInt32(choice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error :" + ex.Message);
                    Console.WriteLine("Please enter INT value only");
                }

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("1 is pressed");
                            _1_addingCourse();
                            break;
                        case 2:
                            Console.WriteLine("2 is pressed");
                            _2_addingStudent();
                            break;
                        case 3:
                            Console.WriteLine("3 is pressed");
                            _3_registeringStuCourse();
                            break;
                        case 4:
                            Console.WriteLine("4 is pressed");
                            _4_dropingStuCourse();
                            break;
                        case 5:
                            Console.WriteLine("5 is pressed");
                            system.DisplayAllCourses();
                            break;
                        case 6:
                            Console.WriteLine("6 is pressed");
                            Console.Write("Enter student ID ::>> ");
                            string studentId = Console.ReadLine();
                            system.DisplayStudentSchedule(studentId);
                            break;
                        case 7:
                            Console.WriteLine("7 is pressed");
                            system.DisplaySystemSummary();
                            break;
                        case 8:
                            Console.WriteLine("Exiting the Program");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice Entered");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

