using AcademyManagment.Context;
using AcademyManagment.DTOs.Student;
using AcademyManagment.Entities;
using AcademyManagment.Repositories.Abstratcs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagment.Services;

public interface IStudentService
{
    Task CreateStudent(StudentCreateDTO dto);
    Task<List<Student>> GetStudentsAsync(bool isTracking = false, params string[] includes);
    Task<Student> GetStudentByIdAsync(int id);
}

public class StudentService(AppDbContext _context, IMapper _mapper, IRepository<Student> _repository) : IStudentService
{
    public async Task CreateStudent(StudentCreateDTO dto)
    {
        await _context.Students.AddAsync(_mapper.Map<Student>(dto));
        await _context.SaveChangesAsync();
    }

    public async Task<Student> GetStudentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Student>> GetStudentsAsync(bool isTracking, params string[] includes)
    {
        var query = _repository.GetAll(false, nameof(Group));

        List<Student> students = await query.ToListAsync();
        return students;
    }
}
