using EfCoreAutomapperOdata.Server.Data.Models;
using EfCoreAutomapperOdata.Server.Extensions;
using EfCoreAutomapperOdata.Shared.Models;
using System.Linq;

namespace EfCoreAutomapperOdata.Server.Mappers
{
    public static class StudentMapper
    {
        public static StudentDto ToDto(this Student model)
        {
            if (model == null)
                return null;

            return new StudentDto
            {
                Id = model.Id,
                Name = model.Name,
                Courses = model.Courses.OrEmptyIfNull().Select(m => m.Course.ToDto()).ToList(),
                Friends = model.Friends.OrEmptyIfNull().Select(m => m.Friend.ToDto()).ToList()
            };
        }

        public static Student FromDto(this StudentDto model)
        {
            if (model == null)
                return null;

            return new Student
            {
                Id = model.Id,
                Name = model.Name,
                Courses = model.Courses.OrEmptyIfNull().Select(m => new CourseStudent { CourseId = m.Id, StudentId = model.Id }).ToList(),
                Friends = model.Friends.OrEmptyIfNull().Select(m => new FriendsRel { FriendId = m.Id, StudentId = model.Id }).ToList()
            };
        }
    }
}
