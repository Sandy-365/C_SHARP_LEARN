# ASP.NET Core Web API with DTO and Swagger – Complete Notes

## 1. What is a Web API

A Web API is an application programming interface that allows communication between systems using HTTP requests.

Common HTTP methods:

| Method | Purpose       |
| ------ | ------------- |
| GET    | Retrieve data |
| POST   | Create data   |
| PUT    | Update data   |
| DELETE | Remove data   |

In ASP.NET Core, APIs are usually built using Controllers.

Example endpoint structure:

```
https://localhost:5001/api/student
```

---

## 2. Project Structure Used

```
Controllers
   StudentController.cs

DTO
   StudentCreateRequestDTO.cs
   StudentResponseDTO.cs

Model
   Student.cs

Program.cs
```

Each layer has a specific responsibility.

---

## 3. Model (Domain Entity)

The Model represents the data structure stored in the system.

```csharp
namespace _2_DTO_StudentApi.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal CourseFeePaid { get; set; }
    }
}
```

Purpose of Model:

* Represents database entity
* Contains all properties of the student
* Used internally in the system

---

## 4. DTO (Data Transfer Object)

DTOs are used to transfer data between client and server without exposing the full model.

Benefits:

* Security
* Control over returned data
* Reduce payload size
* Prevent over-posting

Two DTOs are used.

---

## 5. StudentCreateRequestDTO

Used when creating a new student.

```csharp
namespace _2_DTO_StudentApi.DTO
{
    public class StudentCreateRequestDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal CourseFeePaid { get; set; }
    }
}
```

Purpose:

* Accept data from client request
* Prevent client from sending unwanted fields like Id

Example request body:

```json
{
  "name": "Sandy",
  "age": 22,
  "courseFeePaid": 25000
}
```

---

## 6. StudentResponseDTO

Used when returning limited student data.

```csharp
namespace _2_DTO_StudentApi.DTO
{
    public class StudentResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
```

Purpose:

* Hide sensitive fields
* Send only required data to client

Example response:

```json
[
  {
    "id": 1,
    "name": "Sandy"
  }
]
```

---

## 7. Controller

Controllers handle HTTP requests and responses.

```csharp
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
```

Explanation:

| Attribute      | Meaning                                        |
| -------------- | ---------------------------------------------- |
| ApiController  | Enables API features like automatic validation |
| Route          | Defines URL pattern                            |
| ControllerBase | Base class for API controllers                 |

Base route becomes:

```
api/student
```

---

## 8. In-Memory Data Storage

```csharp
private static List<Student> students = new List<Student>();
```

Purpose:

* Store students temporarily
* Used instead of database

Note: Data resets when application restarts.

---

## 9. Create Student API (POST)

```csharp
[HttpPost]
public IActionResult CreateStudent(StudentCreateRequestDTO request)
```

Endpoint:

```
POST /api/student
```

Steps inside method:

### Convert DTO → Model

```csharp
Student student = new Student
{
    Id = students.Count + 1,
    Name = request.Name,
    Age = request.Age,
    CourseFeePaid = request.CourseFeePaid
};
```

### Add to list

```csharp
students.Add(student);
```

### Return response

```csharp
return Ok(student.Id);
```

---

## 10. Get Students (Basic Info)

```csharp
[HttpGet("basic")]
public ActionResult<List<StudentResponseDTO>> GetStudents()
```

Endpoint:

```
GET /api/student/basic
```

Mapping:

```csharp
var result = students.Select(s => new StudentResponseDTO
{
    Id = s.Id,
    Name = s.Name
}).ToList();
```

Example response:

```json
[
  {
    "id": 1,
    "name": "Sandy"
  }
]
```

---

## 11. Get Total Fees

```csharp
[HttpGet("totalfees")]
public ActionResult<decimal> GetTotalFees()
```

Endpoint:

```
GET /api/student/totalfees
```

Calculation:

```csharp
decimal total = students.Sum(s => s.CourseFeePaid);
```

---

## 12. Program.cs Configuration

```csharp
var builder = WebApplication.CreateBuilder(args);
```

Add controllers:

```csharp
builder.Services.AddControllers();
```

---

## 13. Swagger (API Documentation)

Swagger provides interactive API documentation UI.

Install package:

```
Install-Package Swashbuckle.AspNetCore
```

---

## 14. Swagger Services

```csharp
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();
```

Explanation:

* **AddEndpointsApiExplorer()** → Helps Swagger discover API endpoints.
* **AddSwaggerGen()** → Generates Swagger JSON documentation.
* **AddOpenApi()** → Adds OpenAPI specification support.

---

## 15. Build Application

```csharp
var app = builder.Build();
```

---

## 16. Swagger Middleware

```csharp
app.UseSwagger();
app.UseSwaggerUI();
```

Swagger JSON example:

```
https://localhost:5001/swagger/v1/swagger.json
```

Swagger UI:

```
https://localhost:5001/swagger
```

---

## 17. Authorization Middleware

```csharp
app.UseAuthorization();
```

---

## 18. Map Controllers

```csharp
app.MapControllers();
```

---

## 19. Run Application

```csharp
app.Run();
```

---

## 20. Complete Program Flow

```
CreateBuilder
      ↓
Add Services
      ↓
Build App
      ↓
Add Middleware
      ↓
Map Controllers
      ↓
Run Application
```

---

## 21. API Endpoints Summary

| Method | Endpoint               | Description            |
| ------ | ---------------------- | ---------------------- |
| POST   | /api/student           | Create student         |
| GET    | /api/student/basic     | Get basic student list |
| GET    | /api/student/totalfees | Get total fees         |

---

## 22. Request Flow

```
Client (Swagger/Postman)
        ↓
Controller
        ↓
DTO
        ↓
Model
        ↓
Processing
        ↓
DTO Response
        ↓
Client
```

---

## 23. Advantages of DTO

* Security
* Hide internal fields
* Smaller responses
* Prevent over-posting
* Clean API design

---

## 24. Important Interview Questions

**What is DTO?**
A Data Transfer Object used to transfer data between layers.

**Why DTO instead of Model?**
To avoid exposing internal database entities.

**What is Swagger?**
A tool that provides interactive API documentation.

**What does ApiController attribute do?**
Enables automatic request validation and API-specific features.

**What does IActionResult mean?**
Represents HTTP responses like Ok(), NotFound(), and BadRequest().
