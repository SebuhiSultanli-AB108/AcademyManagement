using AcademyManagment.DTOs.Student;
using AcademyManagment.Entities;
using AutoMapper;

namespace AcademyManagment.Profiles;

public class StudentProfile : Profile
{
    public StudentProfile()
    {
        CreateMap<Student, StudentGetDTO>().ReverseMap();
        CreateMap<Student, StudentCreateDTO>().ReverseMap();
    }
}
