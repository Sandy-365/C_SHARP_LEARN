using Microsoft.AspNetCore.Mvc;

namespace _6_HttpClient.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult getStudents()
        {
            var stu = new List<string>
            {
                "Arun",
                "Kumar",
                "Divya"
            };

            return Ok(stu);
        }
    }
}
