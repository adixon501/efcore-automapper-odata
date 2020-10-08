using System.Collections.Generic;

namespace EfCoreAutomapperOdata.Shared.Models
{
    public class InstructorDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CourseDto> Courses { get; set; }
    }
}