using System.Collections.Generic;

namespace EfCoreAutomapperOdata.Server.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CourseStudent> Courses { get; set; }

        public ICollection<FriendsRel> Friends { get; set; }
    }
}