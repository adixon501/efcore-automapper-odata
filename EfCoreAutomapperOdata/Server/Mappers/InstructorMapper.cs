using EfCoreAutomapperOdata.Server.Data.Models;
using EfCoreAutomapperOdata.Server.Extensions;
using EfCoreAutomapperOdata.Shared.Models;
using System.Linq;

namespace EfCoreAutomapperOdata.Server.Mappers
{
    public static class InstructorMapper
    {
        public static InstructorDto ToDto(this Instructor model)
        {
            if (model == null)
                return null;

            return new InstructorDto
            {
                Id = model.Id,
                Name = model.Name,
                Courses = model.Courses.OrEmptyIfNull().Select(m => m.ToDto()).ToList()
            };
        }

        public static Instructor FromDto(this InstructorDto model)
        {
            if (model == null)
                return null;

            return new Instructor
            {
                Id = model.Id,
                Name = model.Name,
                Courses = model.Courses.OrEmptyIfNull().Select(m => m.FromDto()).ToList()
            };
        }
    }
}
