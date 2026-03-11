using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _7_Change_Data_HttpClient.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentChangedController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> changed()
        {
            List<string> rev = new List<string>();
            HttpClient client = new HttpClient();
            string url = "http://localhost:5117/api/students";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                var students = JsonSerializer.Deserialize<List<string>>(json);

                foreach (var student in students)
                {
                    rev.Add(student.Substring(0,3));
                }
            }
            else
            {
                Console.WriteLine("API call failed");
            }

            return Ok(rev);
        }
    }
}
