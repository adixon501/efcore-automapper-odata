using AutoMapper;
using EfCoreAutomapperOdata.Server.Data.Models;
using EfCoreAutomapperOdata.Shared.Models;
using System.Linq;

namespace EfCoreAutomapperOdata.Server
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Instructor, InstructorDto>();
            CreateMap<InstructorDto, Instructor>();

            CreateMap<Course, CourseDto>()
                .ForMember(dto => dto.Students, opt => opt.MapFrom(src => src.Students));
            CreateMap<CourseDto, Course>()
                .ForMember(ent => ent.Students, ex => ex.MapFrom(x => x.Students));

            CreateMap<CourseStudent, StudentDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(x => x.StudentId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(x => x.Student.Name))
                .ForMember(dto => dto.Friends, opt => opt.MapFrom(x => x.Student.Friends));

            CreateMap<CourseStudent, CourseDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(x => x.CourseId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(x => x.Course.Name))
                .ForMember(dto => dto.Instructor, opt => opt.MapFrom(x => x.Course.Instructor))
                .ForMember(dto => dto.Students, opt => opt.MapFrom(x => x.Course.Students));

            CreateMap<FriendsRel, StudentDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(x => x.FriendId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(x => x.Friend.Name))
                .ForMember(dto => dto.Friends, opt => opt.MapFrom(x => x.Friend.Friends));

            CreateMap<Student, StudentDto>()
                .ForMember(dto => dto.Courses, opt => opt.MapFrom(x => x.Courses))
                .ForMember(dto => dto.Friends, opt => opt.MapFrom(x => x.Friends));
            CreateMap<StudentDto, Student>()
                .ForMember(ent => ent.Courses, ex => ex.MapFrom(x => x.Courses));
        }
    }
}
