using AcademyManagment.Context;
using AcademyManagment.DTOs.Group;
using AcademyManagment.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GroupController(IMapper _mapper, AppDbContext _context) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(GroupCreateDTO dto)
    {
        var x = _mapper.Map<Group>(dto);
        await _context.Groups.AddAsync(x);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _context.Groups.ToListAsync());
    }
}
