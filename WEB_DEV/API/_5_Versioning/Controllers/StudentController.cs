using Microsoft.AspNetCore.Mvc;

namespace _5_Versioning.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(new
            {
                Version = "V1",
                Students = new string[] { "Ram", "John", "Sara" }
            });
        }
    }
}
