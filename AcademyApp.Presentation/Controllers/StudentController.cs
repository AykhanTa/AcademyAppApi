using AcademyApp.Application.Interfaces;
using AcademyApp.Data.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademyApp.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(_studentService.GetAll());
        }
    }
}
