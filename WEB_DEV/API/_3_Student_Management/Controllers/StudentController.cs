using _3_Student_Management.DTO;
using _3_Student_Management.Model;
using Microsoft.AspNetCore.Mvc;

namespace _3_Student_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        public static List<Student> students = new List<Student>();

        [HttpPost]
        public IActionResult CreateStudent(StudentCreateDTO req)
        {
            Student student = new Student
            {
                Id = req.Id,
                Name = req.Name,
                Age = req.Age,
            };

            students.Add(student);
            return Ok(student.Id);
        }

        [HttpPost]
        public IActionResult UpdateStudentMarks(StudentUpdateDTO req)
        {
            bool found = false;
            foreach(Student student in students)
            {
                if(student.Id == req.Id)
                {
                    found = true;
                    student.M1 = req.M1;
                    student.M2 = req.M2;
                    student.Total = req.M1 + req.M2;
                    if (student.Total > 80)
                    {
                        student.Grade = 'O';
                    }
                    else if (student.Total > 60)
                    {
                        student.Grade = 'A';
                    }
                    else if (student.Total > 40)
                    {
                        student.Grade = 'B';
                    }
                    else if (student.Total > 20)
                    {
                        student.Grade = 'C';
                    }
                    else
                    {
                        student.Grade = 'F';
                    }
                }
            }

            if(found)return Ok(req.Id+" Updated");

            return Ok("Data not found");
        }

        [HttpGet]
        public IActionResult GetResultById(int id)
        {

            bool found = false;
            foreach(Student student in students)
            {
                if(student.Id == id)
                {
                    found = true;
                    return Ok(student);
                }
            }

            return Ok("Not found");
        }
    }
}
