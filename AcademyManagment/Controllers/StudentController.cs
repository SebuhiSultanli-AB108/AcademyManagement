using AcademyManagment.DTOs.Student;
using AcademyManagment.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademyManagment.Controllers;

[Route("api/[controller]")]
[ApiController]


public class StudentController(IStudentService _service) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(StudentCreateDTO dto)
    {
        await _service.CreateStudent(dto);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _service.GetStudentsAsync());
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await _service.GetStudentByIdAsync(id));
    }
}
