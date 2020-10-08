using System.Collections.Generic;

namespace EfCoreAutomapperOdata.Server.Data.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}