using _1_FirstApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace _1_FirstApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student{ Id = 1, Name="Sandeep", Marks=24 },
            new Student{ Id = 2, Name="Rahul", Marks=30 },
            new Student{ Id = 3, Name="Aman", Marks=28 },
            new Student{ Id = 4, Name="Priya", Marks=35 },
            new Student{ Id = 5, Name="Rohit", Marks=22 },
            new Student{ Id = 6, Name="Neha", Marks=31 }
        };

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpPost]
        public IActionResult AddThreeNum(int a,int b,int c)
        {
            int res = a + b + c;
            return Ok(res);
        }

        [HttpGet]
        public IActionResult AddNum()
        {
            int res = 0;
            for(int i= 0; i <= 100; i+=2)
            {
                res += i;
            }

            return Ok("Sum of number from 1-100 is ::>> "+res);
        }

        [HttpGet]
        public IActionResult ShowEven()
        {
            List<int> res = new List<int>();
            for(int i= 0;i <= 100; i += 2)
            {
                res.Add(i);
            }
            return Ok("All Even Numbers ::>> " + string.Join(" -> ",res));
        }

        [HttpGet]
        public IActionResult ShowOdd()
        {
            List<int> res = new List<int>();
            for(int i= 0;i <= 100; i ++)
            {
                if(i%2!=0)
                res.Add(i);
            }
            return Ok("All Odd Numbers ::>> "+string.Join(" -> ",res));
        }

        [HttpGet]
        public IActionResult EveryThing(int num1,int num2)
        {
            int res1 = 0;
            for (int i = num1; i <= num2; i += 2)
            {
                res1 += i;
            }


            List<int> res2 = new List<int>();
            for (int i = num1; i <= num2; i += 2)
            {
                res2.Add(i);
            }


            List<int> res3 = new List<int>();
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 != 0)
                    res3.Add(i);
            }

            List<string> finalAnswer = new List<string>();
            finalAnswer.Add("Sum of 😎 number from 1-100 is ::>> " + res1);
            finalAnswer.Add("All Even 🤔 Numbers ::>> " + string.Join(" -> ", res2));
            finalAnswer.Add("All Odd 👍 Numbers ::>> " + string.Join(" -> ", res3));
            return Ok(string.Join("\n\n",finalAnswer));
        }
    }
}