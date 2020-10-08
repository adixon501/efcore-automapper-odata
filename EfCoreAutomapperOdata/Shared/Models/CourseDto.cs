using System.Collections.Generic;

namespace EfCoreAutomapperOdata.Shared.Models
{
    public class CourseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public InstructorDto Instructor { get; set; }

        public ICollection<StudentDto> Students { get; set; }
    }
}
