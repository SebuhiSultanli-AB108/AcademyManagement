using AcademyManagment.DTOs.Group;
using AcademyManagment.Entities;
using AutoMapper;

namespace AcademyManagment.Profiles;

public class GroupProfile : Profile
{
    public GroupProfile()
    {
        CreateMap<Group, GroupCreateDTO>().ReverseMap();
        CreateMap<Group, GroupGetDTO>().ReverseMap();
    }
}
