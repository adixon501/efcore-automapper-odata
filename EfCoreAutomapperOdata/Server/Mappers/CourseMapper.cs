using EfCoreAutomapperOdata.Server.Data.Models;
using EfCoreAutomapperOdata.Server.Extensions;
using EfCoreAutomapperOdata.Shared.Models;
using System.Linq;

namespace EfCoreAutomapperOdata.Server.Mappers
{
    public static class CourseMapper
    {
        public static CourseDto ToDto(this Course model)
        {
            if (model == null)
                return null;

            return new CourseDto
            {
                Id = model.Id,
                Name = model.Name,
                Instructor = model.Instructor.ToDto(),
                Students = model.Students.OrEmptyIfNull().Select(m => m.Student.ToDto()).ToList()
            };
        }

        public static Course FromDto(this CourseDto model)
        {
            if (model == null)
                return null;

            return new Course
            {
                Id = model.Id,
                Name = model.Name,
                Instructor = model.Instructor.FromDto(),
                Students = model.Students.OrEmptyIfNull().Select(m => new CourseStudent { StudentId = m.Id, CourseId = model.Id }).ToList()
            };
        }
    }
}
