using Microsoft.AspNetCore.Mvc;

namespace _5_Versioning.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class Student2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(new
            {
                Version = "V2",
                Students = new string[] { "Ram", "John", "Sara","Sandeep","Manish" }
            });
        }
    }
}
