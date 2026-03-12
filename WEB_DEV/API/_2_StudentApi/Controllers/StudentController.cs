using _2_DTO_StudentApi.DTO;
using _2_DTO_StudentApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace _2_DTO_StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // Create student + hostel
        [HttpPost]
        public IActionResult CreateStudent(StudentCreateDTO dto)
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
                StudentID = student.StudentID,
                HostelName = dto.HostelName,
                RoomNo = dto.RoomNo
            };

            _context.Hostels.Add(hostel);
            _context.SaveChanges();

            return Ok("Student Created");
        }

        // Update room number
        [HttpPut("update-room")]
        public IActionResult UpdateRoom(RoomUpdateDTO dto)
        {
            var hostel = _context.Hostels
                .FirstOrDefault(h => h.StudentID == dto.StudentID);

            if (hostel == null)
                return NotFound();

            hostel.RoomNo = dto.RoomNo;
            _context.SaveChanges();

            return Ok("Room Updated");
        }

        // Delete student
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return NotFound();

            var hostel = _context.Hostels
                .FirstOrDefault(h => h.StudentID == id);

            if (hostel != null)
                _context.Hostels.Remove(hostel);

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Ok("Student Deleted");
        }

        // Read all hostel students
        [HttpGet("hostel-students")]
        public IActionResult GetHostelStudents()
        {
            var data = from s in _context.Students
                       join h in _context.Hostels
                       on s.StudentID equals h.StudentID
                       select new StudentReadDTO
                       {
                           StudentID = s.StudentID,
                           StudentName = s.StudentName,
                           Department = s.Department,
                           Year = s.Year,
                           HostelName = h.HostelName,
                           RoomNo = h.RoomNo
                       };
                       };

            return Ok(data.ToList());
        }

        // Read all college students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }
    }
}
