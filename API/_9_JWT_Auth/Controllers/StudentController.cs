using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _9_JWT_Auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetStudents()
        {
            return Ok(new string[]
            {
            "Arun",
            "Divya",
            "Rahul"
            });
        }
    }
}
