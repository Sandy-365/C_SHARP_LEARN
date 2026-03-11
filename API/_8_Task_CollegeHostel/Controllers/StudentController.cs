using _8_Task_CollegeHostel.DTO;
using _8_Task_CollegeHostel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8_Task_CollegeHostel.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        // Create Student + Hostel
        [HttpPost]
        public IActionResult Create(StudentHostelCreateDTO dto)
        {
            var student = new Student
            {
                StudentName = dto.StudentName,
                Department = dto.Department,
                Year = dto.Year
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            var hostel = new Hostel
            {
                StudentId = student.StudentId,
                HostelName = dto.HostelName,
                RoomNo = dto.RoomNo
            };

            _context.Hostels.Add(hostel);
            _context.SaveChanges();

            return Ok("Student and Hostel created");
        }

        // Update Room Number
        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDTO dto)
        {
            var hostel = _context.Hostels
                .FirstOrDefault(h => h.StudentId == dto.StudentId);

            if (hostel == null)
                return NotFound();

            hostel.RoomNo = dto.RoomNo;
            _context.SaveChanges();

            return Ok("Room updated");
        }

        // Delete Student
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return NotFound();

            var hostel = _context.Hostels
                .FirstOrDefault(h => h.StudentId == id);

            if (hostel != null)
                _context.Hostels.Remove(hostel);

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Ok("Student deleted");
        }

        // Read All Hostel Students
        [HttpGet]
        public IActionResult GetHostelStudents()
        {
            var data = _context.Students
                .Join(_context.Hostels,
                s => s.StudentId,
                h => h.StudentId,
                (s, h) => new StudentHostelReadDTO
                {
                    StudentId = s.StudentId,
                    StudentName = s.StudentName,
                    Department = s.Department,
                    Year = s.Year ?? 0,
                    HostelName = h.HostelName,
                    RoomNo = h.RoomNo ?? 0
                }).ToList();

            return Ok(data);
        }

        // Read All College Students
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_context.Students.ToList());
        }
    }
}
