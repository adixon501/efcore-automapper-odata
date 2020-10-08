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
                .ForMember(dto => dto.Students, opt => {
                    opt.MapFrom(_ => _.Students.Select(y => y.Student));
                });
            CreateMap<CourseDto, Course>()
                .ForMember(ent => ent.Students, ex => ex
                    .MapFrom(x => x.Students.Select(y => new CourseStudent {
                        CourseId = x.Id,
                        StudentId = y.Id
                    })));

            CreateMap<Student, StudentDto>()
                .ForMember(dto => dto.Courses, opt => {
                    opt.MapFrom(x => x.Courses.Select(y => y.Course));
                })
                .ForMember(dto => dto.Friends, opt => {
                    opt.MapFrom(x => x.Friends.Select(y => y.Friend));
                });
            CreateMap<StudentDto, Student>()
                .ForMember(ent => ent.Courses, ex => ex
                    .MapFrom(x => x.Courses.Select(y => new CourseStudent
                    {
                        StudentId = x.Id,
                        CourseId = y.Id
                    })));
        }
    }
}
